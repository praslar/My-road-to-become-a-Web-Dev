$(document).ready(function () {
    col_1_slide = $(".col-1-slide").menuslide({ element_action: '#button-slide-category', element_slide: '.col-1-slide' });
    col_3_slide = $("#col-3").menuslide({ element_action: '#button-slide-col-3', element_slide: '#col-3', position: "right" });

    function resize_do() {
        width = parseInt($(window).width());
        if (width > 799) {
            $(".col-1").jScrollPane(scroll_settings);
            $(".col-2").jScrollPane(scroll_settings);
            $(".col-3").jScrollPane(scroll_settings);
            col_1_slide.removeslide();
        }
        else {
            col_1_slide.setupslide();
        }
        if (width > 991) {
            col_3_slide.removeslide();
            $('.menu-button-slide.right').css('display', 'none');
        }
        else {
            col_3_slide.setupslide();
            $('.menu-button-slide.right').css('display', 'block');
        }
    }
    resize_do();

    $(window).resize(function () {
        resize_do();
    });

});
