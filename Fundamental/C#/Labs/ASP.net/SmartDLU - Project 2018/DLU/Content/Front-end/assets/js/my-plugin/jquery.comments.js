$.fn.comments = function (options) {
    //Lặp qua các selector dùng plugin
    defaults = {
        avatar: "",
        username: "demo",
        comment_id: "",
        user_online: false
    }
    console.log('tung');
    function escapeHtml(text) {
        //Loại bỏ ký tự đặc biệt trong chuỗi
        var map = { '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;', "'": '&#039;' };
        return text.replace(/[&<>"']/g, function (m) { return map[m]; });
    }

    var options = $.extend(defaults, options);
    var that = $(this);
    show_comments = '<center><a href="#">Ẩn câu trả lời</a></center>';
    comments_open = false;
    that.find('.reply-comments').css('display', 'none');
    //Hide all comment reply

    that.find('.show-toggle a').live('click', function () {
        number = $(this).closest('.show-toggle').attr('data-number');

        $(this).closest(".post-comment-content").find(".reply-comments").toggle();
        open = $(this).attr('data-open');
        if (open == "false") {
            $(this).html("Ẩn câu trả lời");
            $(this).attr('data-open', "true");
        }
        else {
            $(this).html('Hiển thị <span class="color-red">' + number + '</span> câu trả lời');
            $(this).attr('data-open', "false");
        }
        return false;
    });
    that.find('a.reply').live('click', function () {
        if (options.user_online) {
            //Thêm khung trả lời
            id = $(this).attr('data-id');
            //Lấy id của comment
            $(this).closest('.post-comment-parent').find('.comment-editor').html("");
            //Mặc định editor
            $(this).closest('.post-comment-parent').find('.comment-editor[data-id=' + id + ']').html(
                '<div class="including">' +
                '<div class="avatar including"><img src="' + options.avatar + '"></div>' +
                '<div class="post-comment-content including">' +
                   '<span class="color-red"><i class="iconsprite-mini iconmini-reply"></i> Trả lời</span><br/>' +
                    '<textarea id="reply-editor" class="form-control full-width" placeholder="Hãy nhập câu trả lời của bạn ..."></textarea>' +
                    '<div class="tool including">' +
                        '<button class="btn btn-primary save-reply-comment pull-right" id="save-reply-comment">Đăng</button>' +
                    '</div></div></div>');
            $(this).closest('.post-comment-parent').find('.reply-comments').fadeIn();
        }
        else { toastr.error("Bạn cần đăng nhập để sử dụng chức năng này"); console.log(1) }
        return false;
    });
    that.find('a.like').live('click', function () {
        if (options.user_online) {
            cm_id = $(this).attr('data-id');
            if (!$(this).hasClass('liked')) {
                count_like = parseInt($(this).attr('count-like')) + 1;
                $(this).addClass('liked');
                $(this).html("&nbsp;Không thích");
                url = get_url('comments/comment?action=like-comment');
            } else {
                count_like = parseInt($(this).attr('count-like')) - 1;
                $(this).removeClass('liked');
                $(this).html("&nbsp;Thích");
                url = get_url('comments/comment?action=unlike-comment');
            }
            $(this).attr('count-like', count_like);
            $(this).closest(".button").find('.show-like-number').html('<span class="color-red">( <span class="count-like">' + count_like + '</span> )</span>');
            $.ajax({
                type: 'POST', url: url, data: { 'cm_id': cm_id }
            });
        }
        else toastr.error("Bạn cần đăng nhập để sử dụng chức năng này");
        return false;
    });
    function get_html_comment(avatar, username, comment_content) {
        return '<div class="post-comment including">' +
                    '<div class="avatar including"><img src="' + avatar + '"></div>' +
                    '<div class="post-comment-content including">' +
                       '<p><span class="color-red">' + username + '</span> trả lời :</p>' +
                        '<p>' + escapeHtml(comment_content) + '</p>' +
                        '<div class="tool including">' +
                            '<div class="pull-right">' +
                                '<div class="button"><i class="iconsprite-mini iconmini-like"></i><a href="#" class="like" count-like="0">&nbsp;Thích</a>&nbsp;' +
                                '&nbsp;<span class="show-like-number"></span></div>' +
                                '<div class="button"><a href="#" class="reply"><i class="iconsprite-mini iconmini-reply"></i> Trả lời</a></div>' +
                            '</div></div></div></div>';
    }
    that.find("#save-reply-comment").live('click', function () {
        if (options.user_online) {
            comment_content = $("#reply-editor").val();
            if (comment_content == "") {
                toastr.error("Vui lòng không để trống trường này");
            }
            else {
                post_comment_last = $(this).closest(".post-comment");
                html_comment = get_html_comment(options.avatar, options.username, comment_content);

                if (!post_comment_last.hasClass('post-comment-parent')) {
                    $(html_comment).insertAfter(post_comment_last);
                    console.log('t' + 1);
                }
                else {
                    post_comment_last.find('.reply-comments').prepend(html_comment);
                    console.log('t' + 2);
                }
                post_comment_parent = $(this).closest('.post-comment-parent');
                post_comment_parent.find('.comment-editor').html("");
                parent_id = post_comment_parent.attr('data-id');

                url = get_url('comments/comment?action=add-comment');
                //console.log(parent_id);
                $.ajax({
                    type: 'POST', url: url,
                    data: { 'comment_id': options.comment_id, 'comment_content': comment_content, 'parent_id': parent_id }
                });
            }
        }
        else toastr.error("Bạn cần đăng nhập để sử dụng chức năng này");
    });
    that.find("#save-comment").live('click', function () {
        if (options.user_online) {
            comment_content = that.find("#comment-editor").val();
            if (comment_content == "") {
                toastr.error("Vui lòng không để trống trường này");
            }
            else {
                post_comment_last = $(this).closest(".post-comment");
                html_comment = get_html_comment(options.avatar, options.username, comment_content);
                $(html_comment).insertAfter(that.find('.post-comment:first'));
                url = get_url('comments/comment?action=add-comment');
                //console.log(parent_id);
                $.ajax({
                    type: 'POST', url: url,
                    data: { 'comment_id': options.comment_id, 'comment_content': comment_content, 'parent_id': 0 }
                });
            }
        }
        else toastr.error("Bạn cần đăng nhập để sử dụng chức năng này");
    });

    return {

    }
}