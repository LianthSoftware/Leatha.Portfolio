using Leatha.Portfolio.Blazor.Models;

namespace Leatha.Portfolio.Blazor.Data
{
    public static class ProjectsData
    {
        public static readonly IReadOnlyList<Project> All = new List<Project>
    {
        new Project
        {
            Name = "Globus",
            DescriptionHtml = """
                <p>Long-term project delivering new features for backends powering products, coupons, shopping lists, image assets.</p>
                <ul class="project-description-list">
                    <li><span>Client communication & analysis</span></li>
                    <li><span>Feature delivery & maintenance</span></li>
                    <li><span>Main authorization system ownership</span></li>
                </ul>
            """,
            YearStart = 2021,
            YearEnd = null, // present
            ImagePath = "img/globus_logo_2.png",
            ImageAlt = "Globus Logo",
            Tags = new[] { "C#", ".NET", "Rest API", "MSSQL", "MongoDB", "Docker", "Authorization", "Architecture", "Analysis" }
        },

        new Project
        {
            Name = "KODYS",
            DescriptionHtml = "<p>Backend & tooling across .NET/C# stack.</p>",
            YearStart = 2019,
            YearEnd = 2021,
            ImagePath = "img/kodys_logo_1.png",
            ImageAlt = "KODYS Logo",
            Tags = new[] { ".NET", "C#" }
        },

        new Project
        {
            Name = "KENDAXA Development",
            DescriptionHtml = "<p>Contributions to internal dev tooling and services.</p>",
            YearStart = 2019,
            YearEnd = 2019,
            ImagePath = "img/kendaxa_logo_2.png",
            ImageAlt = "KENDAXA Logo",
            Tags = new[] { ".NET", "C#" }
        },

        new Project
        {
            Name = "Penzijní Společnost České Pojišťovny",
            DescriptionHtml = "<p>Blazor/.NET work on internal applications.</p>",
            YearStart = 2017,
            YearEnd = 2019,
            ImagePath = "img/penzijni_spolecnost_ceske_pojistovny_logo_2.jpg",
            ImageAlt = "PSČP Logo",
            Tags = new[] { "Blazor", ".NET", "C#" }
        },

        new Project
        {
            Name = "Česká Spořitelna",
            DescriptionHtml = "<p>Blazor/.NET features and integrations.</p>",
            YearStart = 2017,
            YearEnd = 2017,
            ImagePath = "img/ceska_sporitelna_logo_1.png",
            ImageAlt = "ČS Logo",
            Tags = new[] { "Blazor", ".NET", "C#" }
        }
    };
    }
}
