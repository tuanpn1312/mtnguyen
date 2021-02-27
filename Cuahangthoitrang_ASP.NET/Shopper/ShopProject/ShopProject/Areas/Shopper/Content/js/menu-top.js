jQuery(document).ready(function ($) {
    $("#menu-top").position();
    $(window).scroll(function () {
        var posScroll = $(document).scrollTop();
        if (parseInt(posScroll) > parseInt(pos.top)) {
            $("#menu-top").addClass('fixed');
        } else {
            $("#menu-top").removeClass('fixed');
        }
        }
    });
});