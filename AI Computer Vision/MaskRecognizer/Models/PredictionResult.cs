namespace MaskRecognizer.Models
{
    public enum PredictionResult
    {
        WithMask,
        WithoutMask,
        NotRecognized
    }

    public static class PredictionTags
    {
        public const string WithMask = "with-mask";
        public const string WithoutMask = "without-mask";
    }
}
