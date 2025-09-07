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
            => YearEnd is not null ? $"{YearStart} - {YearEnd}" : $"{YearStart} - PRESENT";

        public string AltText
            => string.IsNullOrWhiteSpace(ImageAlt) ? Name : ImageAlt;
    }
}
