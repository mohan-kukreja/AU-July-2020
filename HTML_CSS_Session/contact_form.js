$(document).ready(function() {
$("#submit").click(function() {
var name = $("#name").val();
var email = $("#email").val();
var phone = $("#phone").val();
var message = $("#message").val();

$("#returnMessage").empty(); 
if (name == '' || email == '' || phone == '') {
alert("Please Fill Required Fields");
} else {
// Returns successful data submission message when the entered information is stored in database.
$.post("contact_form.php", {
name1: name,
email1: email,
message1: message,
contact1: phone
}, function(data) {
$("returnMessage").append(data); // Append returned message to message paragraph.
if (data == "Your Query has been received, We will contact you soon.") {
$("#contactForm")[0].reset(); // To reset form fields on success.
}
});
}
});
});