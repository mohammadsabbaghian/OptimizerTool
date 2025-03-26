using Itinero;
using Itinero.IO.Osm;
using Itinero.LocalGeo;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        // Define the URL to the OSM file
        string osmUrl = "https://download.geofabrik.de/europe/netherlands-latest.osm.pbf";
        string jsonFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "osmdata.json");

        // Download the OSM data
        byte[] osmData = await LoadOsmDataAsync(osmUrl, jsonFilePath);

        // Load the OSM data into a RouterDb
        var routerDb = new RouterDb();
        using (var stream = new MemoryStream(osmData))
        {
            routerDb.LoadOsmData(stream, new Railway());
        }

        // Create a router
        var router = new Router(routerDb);

        // Define the coordinates for the origin and destination
        var origin = new Coordinate(52.379189f, 4.899431f); // Amsterdam Centraal
        var destination = new Coordinate(52.308613f, 4.763889f); // Schiphol Airport

        // Resolve the coordinates to the nearest network points
        var originPoint = router.Resolve(new Railway().Fastest(), origin);
        var destinationPoint = router.Resolve(new Railway().Fastest(), destination);

        // Calculate the route
        var route = router.Calculate(new Railway().Fastest(), originPoint, destinationPoint);

        // Output the route
        Console.WriteLine("Route found:");
        foreach (var point in route.Shape)
        {
            Console.WriteLine($"{point.Latitude}, {point.Longitude}");
        }
    }

    static async Task<byte[]> LoadOsmDataAsync(string url, string jsonFilePath)
    {
        if (File.Exists(jsonFilePath))
        {
            // Load data from JSON file
            Console.WriteLine("Loading OSM data from JSON file...");
            using (var stream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<byte[]>(jsonReader);
            }
        }
        else
        {
            // Download data from URL
            Console.WriteLine("Downloading OSM data from URL...");
            byte[] osmData = await DownloadOsmDataAsync(url);


            Console.WriteLine("Start writing to json...");
            // Save data to JSON file
            using (var stream = new FileStream(jsonFilePath, FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(stream))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(jsonWriter, osmData);
            }
            Console.WriteLine("Done writing to json...");

            return osmData;
        }
    }


    static async Task<byte[]> DownloadOsmDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}