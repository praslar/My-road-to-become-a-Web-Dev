$.fn.tabs = function (options) {
    defaults = {
        redirect: false
    };
    var options = $.extend(defaults, options);
    //Lặp qua các selector dùng plugin
    var that = $(this);
    var value = that.find('.tab:first').attr('data-value');
    that.find('.tab:first').fadeIn();
    //Thể hiện tabs đầu tiên
    function set_tab(tab) {
        that.find('.tab').each(function () {
            $(this).css('display', 'none');
        });
        //Ẩn tất cả các tab
        data_class = $(tab).attr('data-class');
        //Lấy tên class cần hiển thị
        $("." + data_class).fadeIn();
        //Hiển thị class
        that.find('.tabs a').removeClass('active');
        $(tab).addClass('active');
        //Kích hoạt active
        value = $(tab).attr("data-value");//Lấy giá trị của tab

        if ($(tab).attr('tab-name') == "comment") {

            $(".fb-comments").attr("data-width", "100%");
            FB.XFBML.parse($(".comments")[0]);
            $(window).resize(function () {
                $(".fb-comments").attr("data-width", "100%");
                FB.XFBML.parse($(".comments")[0]);
            });
            //Set comment facebook
        }
        return false;
    }
    that.find('.tabs a').live('click', function () {
        set_tab(this);
        url = $(this).attr('href');
        if (url != "#" && url != "")
            history.pushState(null, null, url);
        console.log(options.redirect);
        if (!options.redirect)
            return false;
    });
    selectedObjects = this;
    return {
        get_value: function () {
            return value;
        },
        set_tab: function (tab) {
            set_tab(tab);
        }
    }
}