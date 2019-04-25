function Controller_Chuong() {
    var id;
    var idEdit;
    //Modal Create
    this.Modal_CreateChuong = function() {
        $("#Modal_Create").modal("show");
        $.ajax({
            url: "/admin/Chuong/Get_MonHoc",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDMONHOC + `">` + item.TENMONHOC + `</option>`;
                    });
                $("#Get_MonHoc_Creat").html(html);
            }
        });
    };
    //Create function
    this.Create_Chuong = function() {
        var tenChuong = $("#TenChuong_Creat").val();
        var moTa = $("#MoTaChuong_Creat").val();
        var idMonHoc = $("#Get_MonHoc_Creat").val();

        if (tenChuong === "" || idMonHoc === "") {
            $.bootstrapGrowl("Tên chương và tên môn học không được để trống !", { type: 'warning' });
        } else {
            $.ajax({
                url: "/admin/Chuong/Them_Chuong",
                type: "POST",
                data: {
                    tenChuong: tenChuong,
                    moTa: moTa,
                    IDMonHoc: idMonHoc
                },
                dataType: "json",
                success: function(data) {
                    if (data.data === true) {

                        location.reload();

                    } else {
                        $.bootstrapGrowl("Tên chương đã tồn tại!", { type: 'warning' });
                    }
                }
            });
        }
    };


    //Modal Delete
    this.Modal_DeleteChuong = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_Chuong = function() {
        $.ajax({
            url: "/admin/Chuong/Xoa_Chuong?ID=" + id,
            type: "POST",
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Còn tồn tại câu hỏi thuộc chương học này, không thể xóa!", { type: 'warning' });
                }
            }
        });
    };

    //Modal Edit
    this.Modal_EditChuong = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        $.ajax({
            url: "/admin/Chuong/Get_MonHoc",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDMONHOC + `">` + item.TENMONHOC + `</option>`;
                    });
                $("#Get_MonHoc_Edit").html(html);
            }
        });
        $.ajax({
            url: "/admin/Chuong/Get_Chuong?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $.each(data.data,
                    function(id, item) {
                        $("#TenChuong_Edit").val(item.TENCHUONGHOC);
                        $("#MoTaChuong_Edit").val(item.MOTACHUONGHOC);
                    });
            }
        });
    };
    //Edit function
    this.Edit_Chuong = function() {
        var tenChuong = $("#TenChuong_Edit").val();
        var moTa = $("#MoTaChuong_Edit").val();
        var idMonHoc = $("#Get_MonHoc_Edit").val();
        var id = idEdit;

        if (tenChuong === "" || idMonHoc === "") {
            $.bootstrapGrowl("Tên chương và tên môn học không được để trống !", { type: 'warning' });
        }
        $.ajax({
            url: "/admin/Chuong/Edit_Chuong",
            type: "POST",
            data: {
                tenChuong: tenChuong,
                moTa: moTa,
                IDMonHoc: idMonHoc,
                id: id
            },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Không có thông tin gì thay đổi!", { type: 'warning' });
                }
            }
        });
    };
}
