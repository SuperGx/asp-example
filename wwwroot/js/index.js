console.log("JET FA!")

var form = document.getElementById("theForm");
form.hidden = true;

var button = document.getElementById("buyButton");
button.addEventListener("click", function () {
    alert("Buying the item")
});