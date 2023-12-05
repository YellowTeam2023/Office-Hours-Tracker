document.addEventListener("DOMContentLoaded", function () {

function changeHeader() {
    var dropdown = document.getElementById("headerSelector");
    var selectedValue = dropdown.options[dropdown.selectedIndex].text;

    // Get the header element
    var headerElement = document.getElementById("dynamicHeader");

    // Change the header text based on the selected value
    headerElement.innerText = selectedValue;
}

// Function to handle the form submission
function handleFormSubmission(event) {
    // Your existing code to update the header
    changeHeader();

    // Prevent the default form submission behavior
    event.preventDefault();
    }
});