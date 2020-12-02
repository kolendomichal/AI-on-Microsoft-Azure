namespace MaskRecognizer.Models
{
    public enum PredictionResult
    {
        WithMask,
        WithoutMask,
        Negative
    }

    public static class PredictionTags
    {
        public const string WithMask = "with-mask";
        public const string WithoutMask = "without-mask";
        public const string Negative = "Negative";
    }
}
