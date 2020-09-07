$(document).ready(function () {
    console.log("JET FA!")



    var form = $("#theForm");
    form.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        alert("Buying the items")
    });

    var product = $(".product li")
    product.on("click", function () {
        console.log("you clicked on " + $(this).text())
    });


    var $loginForm = $("#login")
    var popupForm = $(".popup-form")

    $loginForm.on("click", function () {
        popupForm.slideToggle(1000);
    });

});