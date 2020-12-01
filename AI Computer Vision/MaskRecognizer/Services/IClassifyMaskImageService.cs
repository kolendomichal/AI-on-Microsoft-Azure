using System.Threading.Tasks;
using MaskRecognizer.Models;
using Microsoft.AspNetCore.Http;

namespace MaskRecognizer.Services
{
    public interface IClassifyMaskImageService
    {
        Task<PredictionResult> CheckIfPersonIsWearingMaskAsync(IFormFile file);
    }
}
