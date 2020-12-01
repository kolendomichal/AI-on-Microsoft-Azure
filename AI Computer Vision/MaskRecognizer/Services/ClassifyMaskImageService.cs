using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MaskRecognizer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace MaskRecognizer.Services
{
    public class ClassifyMaskImageService: IClassifyMaskImageService
    {
        private readonly string _apiSubscriptionKey;
        private readonly string _customVisionUrl;
        private readonly IHttpClientFactory _clientFactory;

        public ClassifyMaskImageService(IConfiguration configuration,
            IHttpClientFactory clientFactory)
        {
            _apiSubscriptionKey = configuration["CustomVisionSubscriptionKey"];
            _customVisionUrl = configuration["CustomVisionUrl"];
            _clientFactory = clientFactory;
        }
        public async Task<PredictionResult> CheckIfPersonIsWearingMaskAsync(IFormFile file)
        {
            var client = _clientFactory.CreateClient();
            var predictionResult = new PredictionApiResponse();
            client.DefaultRequestHeaders.Add("Prediction-Key", _apiSubscriptionKey);

            await using var fileStream = file.OpenReadStream();
            var bytes = new byte[file.Length];
            fileStream.Read(bytes, 0, (int)file.Length);
            using (var content = new ByteArrayContent(bytes))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                var response = await client.PostAsync(_customVisionUrl, content);
                predictionResult = JsonConvert.DeserializeObject<PredictionApiResponse>(await response.Content.ReadAsStringAsync());
            }

            return CheckPredictionResult(predictionResult);
        }


        private static PredictionResult CheckPredictionResult(PredictionApiResponse predictionApiResponse)
        {
            var successfulPrediction = predictionApiResponse.predictions.FirstOrDefault(prediction => prediction.probability > 0.99);

            return (successfulPrediction?.tagName) switch
            {
                PredictionTags.WithMask => PredictionResult.WithMask,
                PredictionTags.WithoutMask => PredictionResult.WithoutMask,
                _ => PredictionResult.NotRecognized,
            };
        }
    }
}
