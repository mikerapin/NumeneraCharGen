var descriptors = document.getElementById("descriptors");
function show() {
    // var input = document.forms[0].descriptors.value;
    var value = descriptors.options[descriptors.selectedIndex].value;
    console.log("Selection value: " + value);
}
descriptors.onchange = show;
show();