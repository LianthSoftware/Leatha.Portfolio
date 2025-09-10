using System.Diagnostics;
using Microsoft.JSInterop;
using System.Globalization;

namespace Leatha.Portfolio.Blazor.WebAssembly.Services
{
    public sealed class LanguageService
    {
        private readonly IJSRuntime _javaScriptRuntime;
        public event Action? Changed;

        public LanguageService(IJSRuntime js)
            => _javaScriptRuntime = js;

        public string Current =>
            CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

        public async Task SetAsync(string lang)
        {
            // Persist to localStorage.
            await _javaScriptRuntime.InvokeVoidAsync("culture.set", lang);

            // Apply immediately.
            var ci = new CultureInfo(lang);

            // Affect the current thread immediately.
            CultureInfo.CurrentCulture = ci;
            CultureInfo.CurrentUICulture = ci;

            // Set defaults for any future threads/tasks.
            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;

            // Call changed handler.
            Changed?.Invoke();
        }
    }
}
