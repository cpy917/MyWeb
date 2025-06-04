$(document).ready(function () {
    $('#BackTop').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 500);
    });

    $(window).scroll(function () {
        if ($(this).scrollTop() > 3) {
            $('#BackTop').fadeIn();
        } else {
            $('#BackTop').fadeOut();
        }
    });
});
