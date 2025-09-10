using Leatha.Portfolio.Blazor.WebAssembly.Models;

namespace Leatha.Portfolio.Blazor.WebAssembly.Data
{
    public static class ProjectsData
    {
        public static readonly IReadOnlyList<Project> All = new List<Project>
        {
            new ()
            {
                Id = 10,
                Name = "Globus",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Long-term engagement delivering features for backend platforms powering products, coupons, shopping lists, and image assets.</p>
                        <ul class="project-description-list">
                            <li><span>Client communication and business analysis</span></li>
                            <li><span>End-to-end feature delivery and maintenance</span></li>
                            <li><span>Ownership of the central authorization system</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Dlouhodobá spolupráce na dodávkách funkcí pro backendové platformy zajišťující produkty, kupóny, nákupní seznamy a práci s obrazovými podklady.</p>
                        <ul class="project-description-list">
                            <li><span>Komunikace se zákazníkem a analýza požadavků</span></li>
                            <li><span>Návrh, implementace a údržba funkcí end-to-end</span></li>
                            <li><span>Zodpovědnost za centrální autorizační systém</span></li>
                        </ul>
                        """
                },
                YearStart = 2021,
                YearEnd = null, // present
                ImagePath = "img/globus_logo_2.png",
                ImageAlt = "Globus Logo",
                Tags = ["C#", ".NET", "Rest API", "MSSQL", "Windows Services", "MongoDB", "Docker", "Architecture", "Analysis", "Authorization", "Job Engine"]
            },

            new()
            {
                Id = 9,
                Name = "Peyvee",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Development of a mobile Android application in Xamarin.Forms.</p>
                        <ul class="project-description-list">
                            <li><span>Implemented with Xamarin.Forms</span></li>
                            <li><span>Regular client communication and continuous delivery</span></li>
                            <li><span>Integrations with map layers and the Android SDK</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Vývoj mobilní aplikace pro Android v Xamarin.Forms.</p>
                        <ul class="project-description-list">
                            <li><span>Implementace v technologii Xamarin.Forms</span></li>
                            <li><span>Pravidelná komunikace s klienty a průběžné dodávání</span></li>
                            <li><span>Integrace mapových vrstev a Android SDK</span></li>
                        </ul>
                        """
                },
                YearStart = 2021,
                YearEnd = null, // present
                ImagePath = "img/peyvee_logo_1.png",
                ImageAlt = "Peyvee Logo",
                Tags = ["C#", ".NET", "Xamarin", "RealmDB", "Mobile", "Android"]
            },

            new()
            {
                Id = 8,
                Name = "KODYS",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Long-term work for industrial clients such as Vítkovice Steel and Plzeňský Prazdroj.</p>
                        <ul class="project-description-list">
                            <li><span>Automation of industrial processes for brewery and foundry operations</span></li>
                            <li><span>Internal website for reporting and project oversight</span></li>
                            <li><span>New features for a warehouse application in a healthcare company</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Dlouhodobé projekty pro průmyslové klienty (např. Vítkovice Steel, Plzeňský Prazdroj).</p>
                        <ul class="project-description-list">
                            <li><span>Automatizace průmyslových procesů v pivovaru a slévárně</span></li>
                            <li><span>Interní web pro reporty a přehled projektů</span></li>
                            <li><span>Nové funkce skladové aplikace pro zdravotnickou společnost</span></li>
                        </ul>
                        """
                },
                YearStart = 2019,
                YearEnd = 2021,
                ImagePath = "img/kodys_logo_1.png",
                ImageAlt = "KODYS Logo",
                Tags = [".NET", "C#", "Rest API", "MSSQL", "SQLite", "ASP.NET MVC", "IoT", "Automation"]
            },

            new()
            {
                Id = 7,
                Name = "KENDAXA Development",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Machine-learning project for legal documents (primarily debtor cases): configuring document zones and automated text extraction.</p>
                        <ul class="project-description-list">
                            <li><span>Recognition and OCR of scanned or handwritten legal documents</span></li>
                            <li><span>ML models and tooling for data extraction</span></li>
                            <li><span>Post-processing and validation/correction of extracted data</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Projekt zaměřený na strojové učení pro zpracování právních dokumentů (převážně dlužnická agenda): konfigurace zón dokumentů a automatická extrakce textu.</p>
                        <ul class="project-description-list">
                            <li><span>Rozpoznávání dokumentů a OCR ze skenů či ručně psaných podkladů</span></li>
                            <li><span>Modely strojového učení a nástroje pro extrakci dat</span></li>
                            <li><span>Následné zpracování a ověřování/korekce získaných dat</span></li>
                        </ul>
                        """
                },
                YearStart = 2019,
                YearEnd = 2019,
                ImagePath = "img/kendaxa_logo_2.png",
                ImageAlt = "KENDAXA Logo",
                Tags = [".NET", "C#", "Tools", "AI", "Legal Documents", "Machine Learning"]
            },

            new()
            {
                Id = 6,
                Name = "Penzijní Společnost České Pojišťovny",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Development of a modular internal application for concluding pension contracts.</p>
                        <ul class="project-description-list">
                            <li><span>Core application for employees working with pension systems</span></li>
                            <li><span>Anti-money-laundering (AML) module</span></li>
                            <li><span>Technical support and bug fixing</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Vývoj modulární interní aplikace pro uzavírání penzijních smluv.</p>
                        <ul class="project-description-list">
                            <li><span>Jádrová aplikace pro zaměstnance pracující s penzijními systémy</span></li>
                            <li><span>Modul proti praní špinavých peněz (AML)</span></li>
                            <li><span>Technická podpora a odstraňování chyb</span></li>
                        </ul>
                        """
                },
                YearStart = 2017,
                YearEnd = 2019,
                ImagePath = "img/penzijni_spolecnost_ceske_pojistovny_logo_2.jpg",
                ImageAlt = "PSČP Logo",
                Tags = [".NET", "C#", "WPF", "AML", "Tools", "Internal System" ]
            },

            new()
            {
                Id = 5,
                Name = "Česká Spořitelna",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Long-term project developing a multi-module internal application for bank loan origination.</p>
                        <ul class="project-description-list">
                            <li><span>Work on loan-debt consolidation processing tens of millions of CZK per day</span></li>
                            <li><span>Complete rewrite of automated tests and coverage of key use cases</span></li>
                            <li><span>Consolidation user-interface module</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Dlouhodobý projekt vývoje vícemodulové interní aplikace pro uzavírání bankovních úvěrů.</p>
                        <ul class="project-description-list">
                            <li><span>Práce na konsolidaci úvěrových závazků zpracovávající desítky milionů Kč denně</span></li>
                            <li><span>Kompletní přepsání automatizovaných testů a pokrytí klíčových scénářů</span></li>
                            <li><span>Modul uživatelského rozhraní pro konsolidaci</span></li>
                        </ul>
                        """
                },
                YearStart = 2017,
                YearEnd = 2017,
                ImagePath = "img/ceska_sporitelna_logo_1.png",
                ImageAlt = "ČS Logo",
                Tags = [".NET", "C#", "Web API", "ASP.NET MVC", "HTML", "CSS"]
            },

            new()
            {
                Id = 4,
                Name = "Česká Pojišťovna",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Member of the “New Technologies” team with room to design and deliver new systems.</p>
                        <ul class="project-description-list">
                            <li><span>Designed and built a tablet application from scratch for agricultural claims handling</span></li>
                            <li><span>Administration of a property-claims application</span></li>
                            <li><span>Both apps supported field workers by downloading and calculating data for claim forms</span></li>
                            <li><span>Responsible for a new version of the JobEngine handling critical internal batch tasks (risk and loan recalculations)</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Člen týmu „Nové technologie“ se širokým prostorem pro návrh a realizaci nových systémů.</p>
                        <ul class="project-description-list">
                            <li><span>Návrh a vývoj tabletové aplikace od základu pro likvidaci zemědělských škod</span></li>
                            <li><span>Správa aplikace pro likvidaci majetkových škod</span></li>
                            <li><span>Obě aplikace podporovaly terénní pracovníky stahováním a výpočtem dat pro formuláře</span></li>
                            <li><span>Odpovědnost za novou verzi JobEngine zajišťující klíčové interní úlohy (přepočty rizik a úvěrů)</span></li>
                        </ul>
                        """
                },
                YearStart = 2015,
                YearEnd = 2016,
                ImagePath = "img/ceska_sporitelna_logo_1.png",
                ImageAlt = "ČP Logo",
                Tags = [".NET", "C#", "MSSQL", "Analysis", "Architecture", "Metro UI", "Windows 8.1", "Store Apps", "Universal Apps", "Job Engine"]
            },

            new()
            {
                Id = 3,
                Name = "XACTI",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Project promoting on-demand house-cleaning services.</p>
                        <ul class="project-description-list">
                            <li><span>Focus on U.S. and Canadian customers</span></li>
                            <li><span>Scheduling affordable home/flat cleaning</span></li>
                            <li><span>Responsibility for the Digital Signature module</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Projekt zaměřený na nabídku úklidových služeb na vyžádání.</p>
                        <ul class="project-description-list">
                            <li><span>Zaměření na zákazníky v USA a Kanadě</span></li>
                            <li><span>Plánování cenově dostupného úklidu domácností a bytů</span></li>
                            <li><span>Zodpovědnost za modul Digitálního podpisu</span></li>
                        </ul>
                        """
                },
                YearStart = 2014,
                YearEnd = 2015,
                ImagePath = "img/ceska_sporitelna_logo_1.png",
                ImageAlt = "Xacti Logo",
                Tags = [".NET", "C#", "Web Application", "HTML", "CSS"]
            },

            new()
            {
                Id = 2,
                Name = "HSI",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Enhancements and support for a modular mapping solution built on Bentley technology.</p>
                        <ul class="project-description-list">
                            <li><span>Configuration of map layers</span></li>
                            <li><span>Extending modules based on client requirements</span></li>
                            <li><span>Internal application for managing configuration</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Rozšiřování a podpora modulárního mapového řešení postaveného na platformě Bentley.</p>
                        <ul class="project-description-list">
                            <li><span>Konfigurace mapových vrstev</span></li>
                            <li><span>Rozšiřování modulů dle požadavků klienta</span></li>
                            <li><span>Interní aplikace pro správu konfigurace</span></li>
                        </ul>
                        """
                },
                YearStart = 2014,
                YearEnd = 2014,
                ImagePath = "img/ceska_sporitelna_logo_1.png",
                ImageAlt = "HSI Logo",
                Tags = [".NET", "C#", "Web Application", "HTML", "CSS", "Windows Forms"]
            },

            new()
            {
                Id = 1,
                Name = "World of Warcraft projects",
                Description = new ProjectDescription
                {
                    EnglishTranslation = """
                        <p class="project-description">Contributions to several private servers and to the main community repository.</p>
                        <ul class="project-description-list">
                            <li><span>Server-side improvements: game logic, quests, encounters</span></li>
                            <li><span>Faithful emulation of Blizzard servers to deliver quality gameplay</span></li>
                            <li><span>Led a 15-member team to launch the Cataclysm expansion live</span></li>
                            <li><span>Notable work on Ulduar bosses: Freya, Hodir, Assembly of Iron, and Auriaya</span></li>
                        </ul>
                        """,
                    CzechTranslation = """
                        <p class="project-description">Příspěvky do několika privátních serverů a do hlavního komunitního repozitáře.</p>
                        <ul class="project-description-list">
                            <li><span>Vylepšení serverové logiky: herní mechaniky, úkoly, souboje</span></li>
                            <li><span>Co nejvěrnější napodobení serverů Blizzard pro kvalitní herní zážitek</span></li>
                            <li><span>Vedení 15členného týmu při spuštění datadisku Cataclysm</span></li>
                            <li><span>Výrazná práce na bossech z Ulduaru: Freya, Hodir, Assembly of Iron a Auriaya</span></li>
                        </ul>
                        """
                },
                YearStart = 2011,
                YearEnd = 2014,
                ImagePath = "img/ceska_sporitelna_logo_1.png",
                ImageAlt = "WoW Logo",
                Tags = ["C/C++", "MySQL", "LUA", "Gaming"]
            }
        };
    }
}
