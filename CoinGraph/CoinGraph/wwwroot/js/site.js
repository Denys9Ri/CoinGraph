// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

var currency = document.getElementById('currency'),
    weight = document.getElementById('weight'),
    result = document.getElementById('result');

currency.addEventListener('change', function () {
    listener(currency);
});

weight.addEventListener('change', function () {
    listener(currency);
});

function listener(elem) {
    var price = elem.querySelector(':checked').getAttribute('data-price'),
        money = weight.value;

    result.innerHTML = multiply(price, money);
}

function multiply(a, b) {
    return a * b;
}