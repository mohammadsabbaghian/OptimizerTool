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

                    if (jpMessage != null)
                    {

                        var spResult = await FilePicker.PickAsync(new PickOptions
                        {
                            PickerTitle = "Please select the corresponding SP file",
                        });

                        if (spResult != null && spResult.FileName.Contains(".xml"))
                        {
                            filePath = spResult.FullPath;
                            spMessage = SferaHandlers.XmlParser.DeserializeXmlFile(filePath) as SFERA_G2B_ReplyMessage;

                            var payload = jpMessage.Item as G2B_ReplyPayload;
                            var jp = payload.JourneyProfile[0];

                            if (spMessage != null)
                            {
                                var spsPayload= spMessage.Item as G2B_ReplyPayload;
                                var sps = spsPayload.SegmentProfile;

                                foreach (var sp in jp.SegmentProfileList)
                                {
                                    if (sps.FirstOrDefault(x => x.SP_ID == sp.SP_ID) == null)
                                    {
                                        throw new Exception("not all sps delivered");
                                    }
                                }

                                // Map the JP and SP
                                var jpMapper = new SferaHandlers.JpMapper();
                                var jpConstraints = jpMapper.Map(jp, sps);
                                var spMapper = new SferaHandlers.SpMapper();
                                var spConstraints = spMapper.Map(jp, sps);


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