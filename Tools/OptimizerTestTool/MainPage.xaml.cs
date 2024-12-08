using System.Collections.ObjectModel;
using TrainCharacteristicsManager;


namespace OptimizerTestTool
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoadClicked(object sender, EventArgs e)
        {
            try
            {
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Please select an XML file",
                });

                if (result != null && result.FileName.Contains(".xml"))
                {
                    string filePath = result.FullPath;
                    // Assuming SferaHandlers.XmlParser.DeserializeXmlFile() accepts a file path
                    SferaHandlers.XmlParser.DeserializeXmlFile(filePath);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as when the user cancels the file picker
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }
    }
}