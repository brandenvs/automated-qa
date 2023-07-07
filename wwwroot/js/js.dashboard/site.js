//!!READ ME!!// Produced by - Branden v Staden || Released on - [unreleased]
//!!FILE: [DASHABOARD]JS-SITE!!//
//INTAIL: 08/07/2023 -->STARTS-->
'-----------------------------------------------------------------------------------------------'
// WRITE-INTIAL-CONNECTION-CONSOLE-LOG
function helloWorld() {
    console.log("AWAIT.net - Automated Web-Application Integrated Testing || ALL RIGHTS RESERVED!");
    console.log("*Your Connection Is Now Secure! Currently Browsing[DASHABOARD]: ", document.URL.toString());
}
window.addEventListener('load', helloWorld);
'-----------------------------------------------------------------------------------------------'

// Manage ACTIVE NAV-LINK-TABS
window.addEventListener('DOMContentLoaded', function () {
    var title = this.document.title;
    console.log(title);
    if (title.startsWith('ToolBox') == true) {
        var navItem = document.querySelector('#toolboxNav');
        navItem.classList.add('active');
    }
    if (title.startsWith('Dashboard') == true) {
        var navItem = document.querySelector('#dashboardNav');
        navItem.classList.add('active');
    }

});
