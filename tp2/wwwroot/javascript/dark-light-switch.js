const switchTheme = () => {
    const body = document.querySelector("body");
    const currentTheme = body.classList.contains("container-dark") ? "dark" : "light";
    const newTheme = currentTheme === "dark" ? "container-light" : "container-dark";
    body.classList.replace(currentTheme, newTheme);
}