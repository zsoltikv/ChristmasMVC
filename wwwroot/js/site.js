// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", function () {
    const toggle = document.getElementById("navToggle");
    const menu = document.getElementById("navMenu");

    if (toggle) {
        toggle.addEventListener("click", function () {
            menu.classList.toggle("active");
        });
    }
});

document.addEventListener("DOMContentLoaded", () => {
    const input = document.getElementById("searchInput");
    const items = document.querySelectorAll(".recipe-item");

    if (!input) return;

    input.addEventListener("input", () => {
        const value = input.value.toLowerCase();

        items.forEach(item => {
            const text = item.innerText.toLowerCase();

            if (text.includes(value)) {
                item.style.display = "";
            } else {
                item.style.display = "none";
            }
        });
    });
});
