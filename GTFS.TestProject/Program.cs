using GTFS;
using GTFS.Entities;
using GTFS.IO;

class Program
{
    static async Task Main(string[] args)
    {
        //Belgium NMBS GTFS data
        string gtfsUrl = "https://gtfs.irail.be/nmbs/gtfs/latest.zip";
        var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test Data");
        await DownloadGtfsZipDataAsync(gtfsUrl);
        var feed = ParseGtfsData(folderPath);

        //If we have a trainnumber we can use it to get the trip
        var trip = feed.Trips.FirstOrDefault(x => x.ShortName == "3110");
        var stopTimes = feed.StopTimes.Where(x => x.TripId == trip.Id).OrderBy(x => x.StopSequence).ToList();
        var shape = feed.Shapes.Where(x => x.Id == trip.ShapeId);
        var route = feed.Routes.Where(x => x.Id == trip.RouteId);
        
        
        //if we have location only
        var stops = feed.Stops.Where(x => x.Id.Contains("S"));
        var initialStation = GetClosestStation(stops);
        var closestTrips = GetClosestTrips(initialStation, feed, DateTime.Now);


        PlanRoute(feed, "Bruxelles-Midi", "Anvers-Central");
    }

    private static object GetClosestTrips(Stop currentStop, GTFSFeed feed, DateTime dateTime)
    {
        var datesToCheck = new List<DateTime>{dateTime.Date};
        if(dateTime.Hour > 23)
        {
            datesToCheck.Add(dateTime.Date.AddDays(1));
        }
        else if (dateTime.Hour < 1)
        {
            datesToCheck.Add(dateTime.Date.AddDays(-1));
        }

        var validServiceIdsCalendarDates = feed.CalendarDates
           .Where(x => datesToCheck.Contains(x.Date) && x.ExceptionType == GTFS.Entities.Enumerations.ExceptionType.Added)
           .Select(x => x.ServiceId);

        //var trips = feed.Trips.Where(x => validServiceIds.Contains(x.ServiceId) &&.).ToList();

        var validStopTimes = feed.StopTimes.Where(x => x.StopId == currentStop.Id);
        var durations = validStopTimes.Select(s => new
        {
            stopTime = s,
            Duration = s.DepartureTime.TotalSeconds - dateTime.TimeOfDay.TotalSeconds
        }).OrderByDescending(x => x.Duration).ToList();
        var currentDayOfWeek = (int)dateTime.DayOfWeek;

        //var validTrips = validStopTimes.Join(feed.Trips, st => st.TripId, t => t.Id, (st, t) => t)
        //    .Join(feed.Calendars, t => t.ServiceId, c => c.ServiceId, (t, c) => new { t.Id, c }).
        //    Where(tc => (currentDayOfWeek == 0 && tc.c.Sunday) || (currentDayOfWeek == 1 && tc.c.Monday) || 
        //    (currentDayOfWeek == 2 && tc.c.Tuesday ) || (currentDayOfWeek == 3 && tc.c.Wednesday) || 
        //    (currentDayOfWeek == 4 && tc.c.Thursday) || (currentDayOfWeek == 5 && tc.c.Friday) || 
        //(currentDayOfWeek == 6 && tc.c.Saturday)).Select(tc => tc.Id);

        return durations.Take(5);
    }

    private static Stop GetClosestStation(IEnumerable<Stop> stops, double lat = 51.044074, double lon = 3.725030)
    {
        var distances = stops.Select(s => new
        {
            Stop = s,
            Distance = GeoDistanceCalculator.CalculateDistance(lat, lon, s.Latitude, s.Longitude)
        }).OrderBy(x => x.Distance).ToList();

        return distances.First().Stop;
    }

    static async Task DownloadGtfsZipDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $@"latest.zip");
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await response.Content.CopyToAsync(fileStream);
            }
        }
    }
    static GTFSFeed ParseGtfsData(string directory)
    {
        var reader = new GTFSReader<GTFSFeed>();
        var feed = new GTFSFeed();
        var source = new GTFSDirectorySource(directory);
        reader.Read(feed, source);
        var stops = feed.Stops.OrderBy(s => s.Name).ToList();

        return feed;
    }
    static void PlanRoute(GTFSFeed feed, string origin, string destination)
    {
        var startTime = DateTime.Now;
        var timeUB = startTime.AddMinutes(30).TimeOfDay.TotalSeconds;
        var timeLB = startTime.AddMinutes(-30).TimeOfDay.TotalSeconds;

        var originStop = feed.Stops.FirstOrDefault(s => s.Name.Contains(origin));
        var destinationStop = feed.Stops.FirstOrDefault(s => s.Name.Contains(destination));

        if (originStop == null || destinationStop == null)
        {
            Console.WriteLine("Origin or destination stop not found.");
            return;
        }

        var originId = originStop.Id.Substring(1);
        var destinationId = destinationStop.Id.Substring(1);

        var originStopTimes = feed.StopTimes.Where(st => st.StopId == originId && st.DepartureTime.TotalSeconds > timeLB && st.DepartureTime.TotalSeconds < timeUB).ToList();
        var destinationStopTimes = feed.StopTimes.Where(st => st.StopId == destinationId && st.DepartureTime.TotalSeconds > timeLB && st.DepartureTime.TotalSeconds < timeUB).ToList();

        var possibleTrips = new List<Trip>();

        foreach (var originStopTime in originStopTimes)
        {
            foreach (var destinationStopTime in destinationStopTimes)
            {
                if (originStopTime.TripId == destinationStopTime.TripId && originStopTime.StopSequence < destinationStopTime.StopSequence)
                {
                    var trip = feed.Trips.FirstOrDefault(t => t.Id == originStopTime.TripId);
                    if (trip != null)
                    {
                        possibleTrips.Add(trip);
                    }
                }
            }
        }

        if (possibleTrips.Count == 0)
        {
            Console.WriteLine("No direct route found.");
            return;
        }

        Console.WriteLine("Route found:");
        foreach (var trip in possibleTrips)
        {
            Console.WriteLine($"TrainNumber: {trip.ShortName}, Route ID: {trip.RouteId}");
            var tripStopTimes = feed.StopTimes.Where(st => st.TripId == trip.Id).OrderBy(st => st.StopSequence).ToList();
            foreach (var stopTime in tripStopTimes)
            {
                var stop = feed.Stops.FirstOrDefault(s => s.Id == stopTime.StopId);
                if (stop != null)
                {
                    Console.WriteLine($"Stop: {stop.Name}, Arrival: {stopTime.ArrivalTime:hh\\:mm\\:ss}, Departure: {stopTime.DepartureTime:hh\\:mm\\:ss}");
                    Console.WriteLine($"Stop: {stop.Name}, Arrival: {stopTime.ArrivalTime.Hours}:{stopTime.ArrivalTime.Minutes}:{stopTime.ArrivalTime.Seconds}, Departure: {stopTime.DepartureTime.Hours}:{stopTime.DepartureTime.Minutes}:{stopTime.DepartureTime.Seconds}");
                }
            }
        }
    }

}