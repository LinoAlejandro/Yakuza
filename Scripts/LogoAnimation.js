$(document).ready(function () {
    $("#img-logo").hover(
        function () {
            $("#img-logo").animate({ "height": "300px", "width": "300px", "margin-left": "-25px" }, 250);
        }, function () {
            $("#img-logo").animate({ "height": "250px", "width": "250px", "margin-left": "0" }, 400);
        }
    );
});