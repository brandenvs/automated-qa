//!!READ ME!!// Produced by - Branden v Staden || Released on - [unreleased]
//!!FILE: [LANDING]JS-SITE!!//
//INITIAL: 08/07/2023 -->STARTS-->
'-----------------------------------------------------------------------------------------------'
//SUMMARY: Write some information & security status to (DOM)console.
function helloWorld() {
    console.log("AWAIT.net - Automated Web-Application Integrated Testing || ALL RIGHTS RESERVED!");
    console.log("*Your Connection Is Now Secure! Currently Browsing[LANDING]: ", document.URL.toString());
}
'-----------------------------------------------------------------------------------------------'

'-----------------------------------------------------------------------------------------------'

'-----------------------------------------------------------------------------------------------'
// Function to show the toast message
function showToast(title, message, type) {
    var toastElement = $('.toast');
    var toast = new bootstrap.Toast(toastElement[0]);
    var toastHeader = toastElement.find('.toast-header');
    var toastTitle = toastHeader.find('#toastTitle');
    var toastBody = toastElement.find('#toastBody');

    // Set the toast title, message, and background color based on the type
    toastTitle.text(title);
    toastBody.text(message);
    toastHeader.removeClass('bg-success bg-danger'); // Remove previous classes
    toastHeader.addClass(type === 'success' ? 'bg-success' : 'bg-danger');

    // Show the toast
    toast.show();
}