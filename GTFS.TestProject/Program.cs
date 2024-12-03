using GTFS;
using GTFS.IO;
using HtmlAgilityPack;
using System.Collections;

class Program
{
    static async Task Main(string[] args)
    {
        // Define the URL to the GTFS file for Belgium
        string gtfsUrl = "https://gtfs.irail.be/nmbs/gtfs/latest";

        // Download the GTFS data
        await DownloadGtfsDataAsync(gtfsUrl);

        var feed = ParseGtfsData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test Data"));

        PlanRoute(feed, "Brussels", "Antwerp");

        Console.WriteLine("GTFS data downloaded successfully.");
    }

    static async Task DownloadGtfsDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            var links = GetLinksFromPageAsync(url).Result;
            foreach (var link in links)
            {
                if (!link.Contains(".txt")) continue;

                HttpResponseMessage response = await client.GetAsync(url + "/" + link);
                response.EnsureSuccessStatusCode();
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $@"Test Data/{link}");
                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await response.Content.CopyToAsync(fileStream);
                }
            }
        }
    }

    static async Task<string[]> GetLinksFromPageAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string pageContent = await response.Content.ReadAsStringAsync();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(pageContent);

            var links = htmlDoc.DocumentNode.SelectNodes("//a[@href]")
                .Select(node => node.GetAttributeValue("href", string.Empty))
                .Where(href => !string.IsNullOrEmpty(href))
                .ToArray();

            return links;
        }
    }



    static GTFSFeed ParseGtfsData(string directory)
    {
        var reader = new GTFSReader<GTFSFeed>();
        var feed = new GTFSFeed();

        var files = Directory.GetFiles(directory, "*.txt");
        
        //reader.Read();

        return feed;
    }

    static void PlanRoute(GTFSFeed feed, string origin, string destination)
    {
        // Define the origin and destination stops
        var originStop = feed.Stops.FirstOrDefault(s => s.Name.Contains(origin));
        var destinationStop = feed.Stops.FirstOrDefault(s => s.Name.Contains(destination));

        if (originStop == null || destinationStop == null)
        {
            Console.WriteLine("Origin or destination stop not found.");
            return;
        }

        // Plan a route (this is a simplified example, actual routing logic will be more complex)
        var trips = feed.Trips.Where(t => t.RouteId == originStop.Id || t.RouteId == destinationStop.Id).ToList();

        Console.WriteLine("Route found:");
        foreach (var trip in trips)
        {
            Console.WriteLine($"Trip ID: {trip.Id}, Route ID: {trip.RouteId}");
        }
    }
}