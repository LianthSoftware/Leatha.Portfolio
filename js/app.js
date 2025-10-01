window.scrollMainToTop = (instant = false) => {
    const el = document.querySelector(".app-main");
    if (el)
        el.scrollTo({ top: 0, behavior: instant ? "instant" : "smooth" });
};

window.scrollToElement = (id, offset = 0) => {
    const el = document.getElementById(id);
    if (el) {
        const top = el.getBoundingClientRect().top + window.scrollY - offset;
        window.scrollTo({ top, behavior: 'smooth' });
    }
};

window.scrollToElementByCss = (id, cssVarName) => {
    const el = document.getElementById(id);
    if (!el) return;

    // read CSS variable
    const rootStyles = getComputedStyle(document.documentElement);
    let offsetStr = rootStyles.getPropertyValue(cssVarName).trim();

    let offset = 0;
    if (offsetStr.endsWith("px")) {
        offset = parseInt(offsetStr, 10);
    } else if (!isNaN(parseInt(offsetStr))) {
        offset = parseInt(offsetStr, 10);
    }

    // find the scroll container
    const container = document.querySelector(".app-main");
    if (!container) return;

    // el.offsetTop is relative to the *offsetParent*, but since your
    // `.app-main` contains the sections directly, it’s fine here.
    const top = el.offsetTop - offset;

    container.scrollTo({ top, behavior: "smooth" });
};

function setHeaderIndex(index) {
    const el = document.querySelector(".app-header");
    if (el)
        el.style.zIndex = index;
}

window.setHashSilently = (hash) => {
    //const h = hash.startsWith("#") ? hash : `#${hash}`;
    const h = hash;
    history.replaceState(null, "", h);
};