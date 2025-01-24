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
                var jpResult = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Please select an JP file",
                });
                SFERA_G2B_ReplyMessage jpMessage;
                SFERA_G2B_ReplyMessage spMessage;

                if (jpResult != null && jpResult.FileName.Contains(".xml"))
                {
                    string filePath = jpResult.FullPath;
                    jpMessage = SferaHandlers.XmlParser.DeserializeXmlFile(filePath) as SFERA_G2B_ReplyMessage;


                    var spResult = await FilePicker.PickAsync(new PickOptions
                    {
                        PickerTitle = "Please select the corresponding SP file",
                    });

                    if (jpResult != null && jpResult.FileName.Contains(".xml"))
                    {
                        filePath = jpResult.FullPath;
                        spMessage = SferaHandlers.XmlParser.DeserializeXmlFile(filePath) as SFERA_G2B_ReplyMessage;

                        if (jpMessage != null)
                        {
                            var jp = jpMessage.Item as JourneyProfile;

                            if (spMessage != null)
                            {
                                var sps = spMessage.Item as SegmentProfile[];

                                foreach (var sp in jp.SegmentProfileList)
                                {
                                    if (sps.FirstOrDefault(x => x.SP_ID == sp.SP_ID) == null)
                                    {
                                        throw new Exception("not all sps delivered");
                                    }
                                }

                            }
                        }
                    }
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