$(function () {
    var userLoginButton = $("#test-popup button[name = 'login']").click(onUserLoginClick);

    function onUserLoginClick() {
        alert("Hello");
    }
});