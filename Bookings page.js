$(function() {
    $("#datepicker").datepicker({
        dateFormat: "yy-mm-dd",
        minDate: 0
    });

    $("#bookingForm").submit(function(e) {
        e.preventDefault();

        var customerID = $("#customerID").val();
        var selectedDate = $("#datepicker").val();

        // Perform validation if needed

        // Submit the form data using AJAX or perform any other operations

        // Clear the form fields
        $("#customerID").val("");
        $("#datepicker").val("");

        // Provide feedback to the user about the successful submission
        // You can display a success message or redirect to another page
    });
});
