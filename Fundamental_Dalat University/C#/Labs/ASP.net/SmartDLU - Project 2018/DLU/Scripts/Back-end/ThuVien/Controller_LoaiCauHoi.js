function Controller_Loaicauhoi() {
    var id;
    var idEdit;
    //Modal Create
    this.Modal_CreateLoaicauhoi = function() {
        $("#Modal_Create").modal("show");
    };
    //Create function
    this.Create_Loaicauhoi = function() {
        var tenLoaicauhoi = $("#TenLoaiCauHoi_Create").val();

        if (tenLoaicauhoi === "") {
            $.bootstrapGrowl("Tên hình thức câu hỏi không được để trống !", { type: 'warning' });
        } else {
            $.ajax({
                url: "/admin/HinhThucCauHoi/Them_Loaicauhoi",
                type: "POST",
                data: {
                    tenLoaicauhoi: tenLoaicauhoi
                },
                dataType: "json",
                success: function(data) {
                    if (data.data === true) {

                        location.reload();

                    } else {
                        $.bootstrapGrowl("Tên hình thức câu hỏi đã tồn tại!", { type: 'warning' });
                    }
                }
            });
        }
    };


    //Modal Delete
    this.Modal_DeleteLoaicauhoi = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_Loaicauhoi = function() {
        $.ajax({
            url: "/admin/HinhThucCauHoi/Xoa_Loaicauhoi?ID=" + id,
            type: "POST",
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl(
                        "Còn tồn tại câu hỏi sử dụng hình thức câu hỏi này! Cần tiến hành xóa câu hỏi trước khi xóa hình thức câu hỏi",
                        { type: 'danger' });
                }
            }
        });
    };

    //Modal Edit
    this.Modal_EditLoaicauhoi = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        $.ajax({
            url: "/admin/HinhThucCauHoi/Get_Loaicauhoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $.each(data.data,
                    function(id, item) {
                        $("#TenLoaiCauHoi_Edit").val(item.TENLOAICAUHOI);
                    });
            }
        });
    };
    //Edit function
    this.Edit_Loaicauhoi = function() {
        var tenLoaicauhoi = $("#TenLoaiCauHoi_Edit").val();
        var id = idEdit;

        if (tenLoaicauhoi === "") {
            $.bootstrapGrowl("Tên hình thức câu hỏi không được để trống !", { type: 'warning' });
        }
        $.ajax({
            url: "/admin/HinhThucCauHoi/Sua_Loaicauhoi",
            type: "POST",
            data: {
                tenLoaicauhoi: tenLoaicauhoi,
                id: id
            },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Hình thức câu hỏi đã tồn tại!", { type: 'warning' });
                }
            }

        });
    };
}
