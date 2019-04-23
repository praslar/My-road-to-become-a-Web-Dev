scroll_settings = { autoReinitialise: true, stickToBottom: true, wheelSpeed: 50 };
function check_file_pdf(file_upload) {
    //Kiểm tra file pdf
    var valid_extensions = /(.pdf)$/i;
    if (valid_extensions.test(file_upload))
        return true;
    else return false;
}
function isInt(value) {
    //Kiểm tra số nguyên
    check = !isNaN(value) &&
           parseInt(Number(value)) == value &&
           !isNaN(parseInt(value, 10));
    if (check == true) {
        if (parseInt(value) <= 0) check = false;
    }
    return check;
}
function get_value(element) {
    return $(element).val();
}
function set_value(element, value) {
    $(element).val(value);
}
function show_toastr(value, type) {
    switch (type) {
        case 'error':

            break;
        case 'info':

            break;
    }
}
toastr.options = { "positionClass": "toast-bottom-right", "timeOut": "6000", "closeButton": true, "extendedTimeOut": "3000" }

$(document).ready(function () {
    $(".grid-menu a").tooltip({ container: 'body' });
    $(".grid-menu .item").live('hover', function () {
        that = $(this);
        $(".grid-menu .item").removeClass('tada');
        $(".grid-menu .item").removeClass('animated');
        $(this).addClass("tada").addClass("animated");
    });
    grid_menu_slide = $(".grid-menu").menuslide({ element_action: '#button-slide-app' });
    function resize_do() {
        width = parseInt($(window).width());
        if (width > 799)
            grid_menu_slide.removeslide();
        else grid_menu_slide.setupslide();
    }

    $(window).resize(function () {
        resize_do();
    });
    resize_do();


});
