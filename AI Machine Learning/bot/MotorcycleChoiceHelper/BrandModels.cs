using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace MotorcycleChoiceHelper
{
    public static class BrandModels
    {
        [FunctionName("brandModels")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "brand/{brand}")] HttpRequest req,
            string brand,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            log.LogInformation($"{brand}");
            var jsonDb = Utils.LoadJsonDb();

            var models = jsonDb.motorcycles
                .Where(x => Utils.ComputeStringSimilarity(x.Brand, brand) < 5)
                .SelectMany(x => x.Models)
                .Select(x => x.Name);

            return new OkObjectResult(models);
        }
    }
}
