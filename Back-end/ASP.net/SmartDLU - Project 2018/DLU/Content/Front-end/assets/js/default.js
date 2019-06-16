function setModal(title, message) {
    $("#modal-title").html(title);
    $("#modal-message").html(message);
    $("#my-modal").modal("show");
}
function addPopover(element, position, content) {
    element.attr('data-placement', position);
    element.attr('data-content', content);
    element.popover('show');
}
function removePopover(element) {
    element.popover('hide');
    element.removeAttr('data-placement');
    element.removeAttr('data-content');
}
function startLoad() { $('.loading').css('display', 'block'); }
function stopLoad() { $('.loading').css('display', 'none'); }

$('.changePage').live('click', function () {
    startLoadPage();
});
function completeLoadPage() {
    $("#ytLoad").css('width', '0px');
}
function startLoadPage() {
    $("#ytLoad").fadeIn();
    $("#ytLoad").css('width', '80%');
}
function stopLoadPage() {
    $("#ytLoad").css('width', '80%');
    $("#ytLoad").fadeIn();
    $("#ytLoad").css('width', '100%');
    $("#ytLoad").fadeOut(1600, completeLoadPage);
}
function scroll_to(element) {
    $('html, body').animate({
        scrollTop: $(element).offset().top
    }, 400);
}

function check_file_pdf(file_upload) {
    var valid_extensions = /(.pdf)$/i;
    if (valid_extensions.test(file_upload))
        return true;
    else return false;
}
$('.form-signup').submit(function () {
    startLoadPage();
})

$('.a-menuhot').live('click', function () {
    $("#menu-hot").modal('show');
    return false;
});