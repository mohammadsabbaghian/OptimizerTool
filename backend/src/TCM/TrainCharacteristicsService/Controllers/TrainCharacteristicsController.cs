using Microsoft.AspNetCore.Mvc;
using TrainCharacteristicsManager;
using Shared.Models.Train;

namespace TrainCharacteristicsService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainCharacteristicsController : ControllerBase
    {
        [HttpPost]
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