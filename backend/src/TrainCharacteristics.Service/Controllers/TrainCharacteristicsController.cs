using Microsoft.AspNetCore.Mvc;
using Shared.Models.Train;
using TrainCharacteristicsManager;

namespace TrainCharacteristics.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainCharacteristicsController : ControllerBase
    {
        private readonly ILogger<TrainCharacteristicsController> _logger;

        public TrainCharacteristicsController(ILogger<TrainCharacteristicsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTrainCharacteristics")]
        public async Task<IActionResult> GetTrainCharacteristicsAsync([FromBody] List<TrainUnit> trainUnits)
        {
            try
            {
                var parameters = await TrainUnitParametersRepository.GetTrainUnitParametersAsync();

                // Use TrainCharacteristicsBuilder to build the full set
                var builder = new TrainCharacteristicsBuilder(parameters);
                var fullCharacteristics = builder.Build(trainUnits);

                // Return the result as JSON
                return Ok(fullCharacteristics);
            }
            catch (Exception ex)
            {
                // Handle errors and return appropriate response
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
