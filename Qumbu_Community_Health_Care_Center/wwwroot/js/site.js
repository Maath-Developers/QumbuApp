// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Tempdata
setTimeout(function () {
    var tempdat = document.getElementById('tempdata');
    if (tempdat) {
        tempdat.remove();
        tempdat.textContent = '';
    }
}, 5000);
