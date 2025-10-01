window.culture = {
    get: () => localStorage.getItem("ui-culture"),
    set: (lang) => localStorage.setItem("ui-culture", lang),
    browser: () => (navigator.language || "en").split("-")[0] // "en-US" -> "en"
};