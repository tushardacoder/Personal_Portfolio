(() => {
    const root = document.documentElement;
    const toggle = document.querySelector(".theme-toggle");
    const storageKey = "tushar-portfolio-theme";
    const systemTheme = window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light";

    let theme = systemTheme;
    try {
        theme = localStorage.getItem(storageKey) || systemTheme;
    } catch {
        // Keep the system preference if browser storage is unavailable.
    }

    const applyTheme = (value) => {
        root.dataset.theme = value;
        if (toggle) {
            const dark = value === "dark";
            toggle.setAttribute("aria-label", `Switch to ${dark ? "light" : "dark"} theme`);
            toggle.querySelector(".theme-label").textContent = dark ? "Light" : "Dark";
            toggle.querySelector(".theme-icon").textContent = dark ? "☼" : "◐";
        }
    };

    applyTheme(theme);
    toggle?.addEventListener("click", () => {
        theme = root.dataset.theme === "dark" ? "light" : "dark";
        applyTheme(theme);
        try {
            localStorage.setItem(storageKey, theme);
        } catch {
            // The selected theme remains active for this page.
        }
    });

    const portrait = document.querySelector(".portrait-image");
    portrait?.addEventListener("error", () => {
        portrait.hidden = true;
        const fallback = document.querySelector(".portrait-fallback");
        if (fallback) fallback.hidden = false;
    });
})();
