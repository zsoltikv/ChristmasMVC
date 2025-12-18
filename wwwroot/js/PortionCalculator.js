document.getElementById("calculatePortion").addEventListener("click", function () {
    let input = document.getElementById("desiredPortion");
    let desired = parseInt(input.value, 10); // csak egész szám
    const originalServings = parseFloat(input.dataset.original);

    if (!desired || desired <= 0) {
        alert("Please enter a valid number of servings!");
        return;
    }

    const ingredients = document.querySelectorAll(".ingredients-list .ingredient-item");

    ingredients.forEach(li => {
        let amountSpan = li.querySelector(".ingredient-amount");
        let originalText = amountSpan.innerText.trim();

        const match = originalText.match(/^([\d.,\/]+)\s*(.*)$/);
        if (match) {
            let numberPart = match[1].replace(',', '.');
            let unitPart = match[2];

            let originalAmount = parseFloat(numberPart);
            if (!isNaN(originalAmount)) {
                const scaledAmount = (originalAmount / originalServings) * desired;
                amountSpan.innerText = scaledAmount.toFixed(1) + (unitPart ? " " + unitPart : "");
            }
        }
    });
});