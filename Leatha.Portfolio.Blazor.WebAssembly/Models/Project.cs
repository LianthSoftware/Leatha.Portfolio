using System.Globalization;

namespace Leatha.Portfolio.Blazor.WebAssembly.Models
{
    public sealed class Project
    {
        public int Id { get; set; }

        public string Name { get; init; } = "";

        /// <summary>
        /// Trusted HTML string (may contain <p></p>, <ul></ul>, <li></li>, etc.) with translations.
        /// </summary>
        public ProjectDescription Description { get; init; } = null!;

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

            return $"{ YearStart } - { GetPresentValue() }";
        }

        // #TODO: Fix this.
        private string GetPresentValue()
        {
            var lang = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLowerInvariant();
            if (lang.StartsWith("cs"))
                return "SOUČASNOST";

            return "PRESENT";
        }
    }

    public sealed class ProjectDescription
    {
        public string CzechTranslation { get; set; } = null!;

        public string EnglishTranslation { get; set; } = null!;

        public string GetTranslation(string? code = null)
        {
            var lang = (code ?? CultureInfo.CurrentUICulture.TwoLetterISOLanguageName)
                .ToLowerInvariant();

            // Czech translation. If not available, switch to English again.
            if (lang.StartsWith("cs"))
                return string.IsNullOrWhiteSpace(CzechTranslation) ? EnglishTranslation : CzechTranslation;

            // Default to English.
            return EnglishTranslation;
        }
    }
}
