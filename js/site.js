$(document).ready(function () {
    $(".fancybox").fancybox();
    $('#sidebar').affix({
        offset: {
            top: $('header').height()
        }
    });
});
