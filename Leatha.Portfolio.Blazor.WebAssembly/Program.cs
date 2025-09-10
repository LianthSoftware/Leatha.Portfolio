using Leatha.Portfolio.Blazor.WebAssembly;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Globalization;
using Leatha.Portfolio.Blazor.WebAssembly.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddLocalization();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<LanguageService>();    // for runtime switching

var app = builder.Build();

// Get language from localStorage or browser and apply it *before* first render.
var js = app.Services.GetRequiredService<IJSRuntime>();

var stored = await js.InvokeAsync<string>("culture.get");
var selected = string.IsNullOrWhiteSpace(stored)
    ? await js.InvokeAsync<string>("culture.browser")
    : stored;

SetCulture(selected);

await app.RunAsync();

return;

static void SetCulture(string lang)
{
    try
    {
        var ci = new CultureInfo(lang);
        CultureInfo.CurrentCulture = ci;
        CultureInfo.CurrentUICulture = ci;
        CultureInfo.DefaultThreadCurrentCulture = ci;
        CultureInfo.DefaultThreadCurrentUICulture = ci;
    }
    catch
    {
        var ci = new CultureInfo("en");
        CultureInfo.CurrentCulture = ci;
        CultureInfo.CurrentUICulture = ci;
        CultureInfo.DefaultThreadCurrentCulture = ci;
        CultureInfo.DefaultThreadCurrentUICulture = ci;
    }
}