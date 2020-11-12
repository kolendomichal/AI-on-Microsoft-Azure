using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace MotorcycleChoiceHelper
{
    public static class Motorcycles
    {
        [FunctionName("modelDetails")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "brand/{brand}/model/{model}")]
            HttpRequest req,
            string brand,
            string model,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.\n");
            log.LogInformation($"{brand},{model}\n");
            

            var jsonDb = Utils.LoadJsonDb();
            var models = jsonDb.motorcycles
                .First(x => Utils.ComputeStringSimilarity(x.Brand, brand) < 5).Models
                .First(m => Utils.ComputeStringSimilarity(m.Name, model) < 5);
            
            log.LogInformation(models.ToString());

            return new OkObjectResult(models);
        }
    }
}
