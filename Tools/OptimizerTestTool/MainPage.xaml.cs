using System.Collections.ObjectModel;
using TrainCharacteristicsManager;


namespace OptimizerTestTool
{
    public partial class MainPage : ContentPage
    {
        private JourneyProfile jp;
        private SegmentProfile[] sp;

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

                var spResult = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Please select the corresponding SP file",
                });

                if (jpResult == null || !jpResult.FileName.Contains(".xml"))
                    throw new InvalidOperationException("Invalid JP file.");

                if (spResult == null || !spResult.FileName.Contains(".xml"))
                    throw new InvalidOperationException("Invalid SP file.");

                // Deserialize the profiles
                (jp, sp) = DeserializeProfiles(jpResult, spResult);
                mapProfiles(jp, sp);
            }
            catch (Exception ex)
            {
                // Handle exceptions, such as when the user cancels the file picker
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

        private static (JourneyProfile jp, SegmentProfile[] sp) DeserializeProfiles(FileResult jpResult, FileResult spResult)
        {
            SFERA_G2B_ReplyMessage jpMessage;
            SFERA_G2B_ReplyMessage spMessage;

            jpMessage = SferaHandlers.XmlParser.DeserializeXmlFile(jpResult.FullPath) as SFERA_G2B_ReplyMessage ?? throw new InvalidOperationException("Failed to deserialize JP file.");
            spMessage = SferaHandlers.XmlParser.DeserializeXmlFile(spResult.FullPath) as SFERA_G2B_ReplyMessage ?? throw new InvalidOperationException("Failed to deserialize SP file.");

            if (jpMessage == null || spMessage == null)
                throw new InvalidCastException("Failed to cast the message to the correct type.");

            var jpPayload = jpMessage.Item as G2B_ReplyPayload;
            var spsPayload = spMessage.Item as G2B_ReplyPayload;

            if (jpPayload == null || spsPayload == null)
                throw new InvalidCastException("Failed to cast the payload to the correct type.");

            var jp = jpPayload.JourneyProfile[0];
            var sps = spsPayload.SegmentProfile;

            foreach (var sp in jp.SegmentProfileList)
            {
                if (sps.FirstOrDefault(x => x.SP_ID == sp.SP_ID) == null)
                {
                    throw new Exception("Not all segment profiles delivered.");
                }
            }
            return (jp, sps);
        }
        private void mapProfiles(JourneyProfile jp, SegmentProfile[] sps)
        {
            // Map the JP and SP
            var jpMapper = new SferaHandlers.JpMapper();
            var jpConstraints = jpMapper.Map(jp, sps);
            var spMapper = new SferaHandlers.SpMapper();
            var spConstraints = spMapper.Map(jp, sps);
            return;
        }
    }
}