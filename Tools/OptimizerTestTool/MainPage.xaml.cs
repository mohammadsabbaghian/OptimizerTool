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
                var jpResult = await PickFileAsync("Please select a JP file");

                var jpMessage = DeserializeFile<SFERA_G2B_ReplyMessage>(jpResult.FullPath, "JP");
                var jpPayload = GetPayload(jpMessage, "JP");

                var jp = jpPayload.JourneyProfile[0];
                var sps = jpPayload.SegmentProfile;

                if (sps == null)
                {
                    var spResult = await PickFileAsync("Please select the corresponding SP file");

                    var spMessage = DeserializeFile<SFERA_G2B_ReplyMessage>(spResult.FullPath, "SP");
                    var spsPayload = GetPayload(spMessage, "SP");
                    sps = spsPayload.SegmentProfile;
                }

                ValidateSegmentProfiles(jp, sps);
                MapProfiles(jp, sps);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

        private G2B_ReplyPayload GetPayload(SFERA_G2B_ReplyMessage message, string fileType)
        {
            var payload = message.Item as G2B_ReplyPayload;
            if (payload == null)
            {
                throw new InvalidCastException($"Failed to cast the payload to the correct type for {fileType} file.");
            }
            return payload;
        }

        private void MapProfiles(JourneyProfile jp, SegmentProfile[] sps)
        {
            // Map the JP and SP
            var jpMapper = new SferaHandlers.JpMapper();
            var jpConstraints = jpMapper.Map(jp, sps);
            var spMapper = new SferaHandlers.SpMapper();
            var spConstraints = spMapper.Map(jp, sps);
            return;
        }
        private void ValidateSegmentProfiles(JourneyProfile jp, SegmentProfile[] sps)
        {
            foreach (var sp in jp.SegmentProfileList)
            {
                if (sps.FirstOrDefault(x => x.SP_ID == sp.SP_ID) == null)
                {
                    throw new Exception("Not all segment profiles delivered.");
                }
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

        private T DeserializeFile<T>(string filePath, string fileType) where T : class
        {
            var message = SferaHandlers.XmlParser.DeserializeXmlFile(filePath).Item1 as T;
            if (message == null)
                throw new InvalidOperationException($"Failed to deserialize {fileType} file.");
            return message;
        }
    }
}