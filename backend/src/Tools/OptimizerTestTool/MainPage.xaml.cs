using Shared.Models.Route;
using Shared.Models.Timetable;

namespace OptimizerTestTool
{
    public partial class MainPage : ContentPage
    {
        private TimeConstraints TimeConstraints;
        private RouteConstraints RouteConstraints;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoadClicked(object sender, EventArgs e)
        {
            try
            {
                var jpResult = await PickFileAsync("Please select a JP file");

                // Deserialize the JP file and get the handler
                var (jpMessage, jpVersion, withSp ) = DeserializeFile(jpResult.FullPath, "JP");
                var handler = SferaMessageHandlerFactory.GetHandler(jpVersion);

                ISferaMessage spMessage = null;
                if (!withSp)
                {
                    var spResult = await PickFileAsync("Please select a SP file");
                    (spMessage, string _, bool _) = DeserializeFile(spResult.FullPath, "SP");
                }

                // Delegate validation and mapping to the handler
                (TimeConstraints, RouteConstraints) = handler.MapProfiles(jpMessage, spMessage);

                await DisplayAlert("Success", "Mapping was successful.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

        private async Task<FileResult> PickFileAsync(string pickerTitle)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = pickerTitle,
            });

            if (result == null || !result.FileName.Contains(".xml"))
                throw new InvalidOperationException($"Invalid file.");

            return result;
        }

        private (ISferaMessage, string, bool) DeserializeFile(string filePath, string fileType)
        {
            // Use the XmlParser to get the message and version
            var (message, _, version, withSP) = XmlParser.DeserializeXmlFile(filePath);

            if (message == null)
                throw new InvalidOperationException($"Failed to deserialize {fileType} file.");

            return (message, version, withSP);
        }
    }
}