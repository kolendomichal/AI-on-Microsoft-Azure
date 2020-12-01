
using System;
using System.Collections.Generic;

namespace MaskRecognizer.Models
{
    public class PredictionApiResponse
    {
        public string id { get; set; }
        public string project { get; set; }
        public string iteration { get; set; }
        public DateTime created { get; set; }
        public List<Prediction> predictions { get; set; }
    }
}
