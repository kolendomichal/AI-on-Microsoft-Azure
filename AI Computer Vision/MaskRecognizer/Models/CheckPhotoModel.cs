

using Microsoft.AspNetCore.Http;

namespace MaskRecognizer.Models
{
    public class CheckPhotoModel
    {
        public IFormFile MyImage { get; set; }
    }
}
