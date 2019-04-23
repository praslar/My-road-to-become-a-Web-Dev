function Controller_CauTraLoi() {
    var id;
    var idEdit;
    //Modal Delete
    this.Modal_DeleteCauTraLoi = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_CauTraLoi = function() {
        $.ajax({
            url: "/admin/CauTraLoi/Xoa_CauTraLoi",
            type: "POST",
            data: { ID: id },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else
                    $.bootstrapGrowl("Câu hỏi đang được sử dụng cho bộ đề! Không thể xóa", { type: 'warning' });
            }
        });
    };
    //Modal Edit
    this.Modal_EditCauTraLoi = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        $.ajax({
            url: "/admin/CauTraLoi/Get_CauTraLoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function (data) {
                $.each(data.data,
                    function (id, item) {
                        $("#CauTraLoi_MaCauHoi_Sua").text(item.IDCAUHOI);
                    });
            }
        });
        $.ajax({
            url: "/admin/CauTraLoi/Get_CauTraLoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function (data) {
                $.each(data.data,
                    function (id, item) {
                        CKEDITOR.instances["CauTraLoi_NoiDung_Edit"].setData(item.NOIDUNGCAUTL);
                    });
            }
        });
    };
    //Edit function
    this.Edit_CauTraLoi = function() {
        var idCauHoi = $("#CauTraLoi_MaCauHoi_Sua").text();
        var dungsai = $("#CauTraLoi_DungSai_Edit").val();
        var noiDungCauTraLoi = CKEDITOR.instances["CauTraLoi_NoiDung_Edit"].getData();
        var index = $("#CauTraLoi_Index_Edit").val();
        if (noiDungCauTraLoi === "") {
            $.bootstrapGrowl("Nội dung câu trả lời không được để trống !", { type: 'warning' });
        }
        $.ajax({
            url: "/admin/CauTraLoi/Sua_CauTraLoi",
            type: "POST",
            data: {
                ID: idEdit,
                IDCH: idCauHoi,
                noiDung: noiDungCauTraLoi,
                dungSai: dungsai,
                index: index
            },
            dataType: "json",
            success: function (data) {
                if (data.data === true) {
                    location.reload();
                } else if (data.data === "InvalidNoiDung") {
                    $.bootstrapGrowl("Câu trả lời đã tồn tại!!", { type: 'warning' });
                } else if (data.data === "invalidIndex") {
                    $.bootstrapGrowl("Index câu trả lời đã tồn tại!!", { type: 'warning' });
                } else if (data.data === "invalidDapAnDung") {
                    $.bootstrapGrowl("Đã đủ đáp án đúng cho câu hỏi!!", { type: 'warning' });
                } else
                    $.bootstrapGrowl("Lỗi thêm!", { type: 'warning' });
            }
            
        });
    };

}
