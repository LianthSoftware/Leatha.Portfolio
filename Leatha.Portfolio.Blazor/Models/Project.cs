namespace Leatha.Portfolio.Blazor.Models
{
    public sealed class Project
    {
        public string Name { get; init; } = "";

        /// <summary>
        /// Trusted HTML string (may contain <p></p>, <ul></ul>, <li></li>, etc.).
        /// </summary>
        public string? DescriptionHtml { get; init; }

        public int YearStart { get; init; }

        public int? YearEnd { get; init; }   // null => present

        public string ImagePath { get; init; } = "";

        public string? ImageAlt { get; init; }

        public string[] Tags { get; init; } = Array.Empty<string>();

        public string YearRange
            => GetYearRange();

        public string AltText
            => string.IsNullOrWhiteSpace(ImageAlt) ? Name : ImageAlt;

        private string GetYearRange()
        {
            if (YearStart == YearEnd)
                return YearStart.ToString();

            if (YearEnd is not null)
                return $"{ YearStart } - { YearEnd }";

            return $"{ YearStart } - PRESENT";
        }
    }
}
