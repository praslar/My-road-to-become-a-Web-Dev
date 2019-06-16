$.fn.menuslide = function (options) {
    //Lặp qua các selector dùng plugin
    defaults = {
        position: "left",
        element_slide: "",
        element_action: ""
    };

    var that = $(this);
    var options = $.extend(defaults, options);
    var element_action = $(options.element_action);

    if (!that.hasClass('col-slide')) {
        that.addClass('col-slide-' + options.position);
        that.addClass('col-slide-transition');
        that.addClass('col-slide');
    }

    element_action.on('click', function () {
        that.addClass('col-slide-' + options.position + '-show');
        $(".fog").addClass('fog-active');
        return false;
    });

    $('.fog').on('click', function () {
        console.log(options.element_slide);
        that.removeClass('col-slide-' + options.position + '-show');
        $(".fog").removeClass('fog-active');
    });
    return {
        removeslide: function () {
            that.removeClass('col-slide-' + options.position);
            that.removeClass('col-slide-transition');
            that.removeClass('col-slide');
        },
        setupslide: function () {
            that.addClass('col-slide-' + options.position);
            that.addClass('col-slide-transition');
            that.addClass('col-slide');
        },
        closeslide: function () {
            that.removeClass('col-slide-' + options.position + '-show');
            $(".fog").removeClass('fog-active');
        }
    }
}