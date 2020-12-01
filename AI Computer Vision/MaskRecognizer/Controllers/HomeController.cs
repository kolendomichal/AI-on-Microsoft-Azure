using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MaskRecognizer.Models;
using Microsoft.AspNetCore.Http;
using MaskRecognizer.Services;

namespace MaskRecognizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassifyMaskImageService _classifyMaskImageService;

        public HomeController(IClassifyMaskImageService classifyMaskImageService)
        {
            _classifyMaskImageService = classifyMaskImageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<JsonResult> ClassifyMaskImage(IFormFile file)
        {
            var result = await _classifyMaskImageService.CheckIfPersonIsWearingMaskAsync(file);
            return Json(new { success = true, message = result });
        }
    }
}
