function Controller_MucDoKho() {
    var id;
    var idEdit;
    //Modal Create
    this.Modal_CreateMucDoKho = function() {
        $("#Modal_Create").modal("show");
    };
    //Create function
    this.Create_MucDoKho = function() {
        var tenMucDoKho = $("#TenMucDoKho_Create").val();
        var moTa = $("#MoTaMucDoKho_Create").val();
        if (tenMucDoKho === "" || moTa === "") {
            $.bootstrapGrowl("Số lượng mức độ khó và mô tả không được để trống !", { type: 'warning' });
        } else {
            $.ajax({
                url: "/admin/SoLuongDoKho/Them_MucDoKho",
                type: "POST",
                data: {
                    tenMucDoKho: tenMucDoKho,
                    moTa: moTa
                },
                dataType: "json",
                success: function(data) {
                    if (data.data === true) {
                        location.reload();
                    } else {
                        $.bootstrapGrowl("Số lượng độ khó đã tồn tại!", { type: 'warning' });
                    }
                }
            });
        }
    };


    //Modal Delete
    this.Modal_DeleteMucDoKho = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_MucDoKho = function() {
        $.ajax({
            url: "/admin/SoLuongDoKho/Xoa_MucDoKho?ID=" + id,
            type: "POST",
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Lỗi dữ liệu, không thể xóa!", { type: 'danger' });
                }
            }
        });
    };

    //Modal Edit
    this.Modal_EditMucDoKho = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        $.ajax({
            url: "/admin/SoLuongDoKho/Get_MucDoKho?id=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $.each(data.data,
                    function(id, item) {
                        $("#TenMucDoKho_Edit").val(item.TENMUCDOKHO);
                        $("#MoTaMucDoKho_Edit").val(item.MOTAMUCDOKHO);
                    });

            }
        });
    };
    //Edit function
    this.Edit_MucDoKho = function() {
        var tenMucDoKho = $("#TenMucDoKho_Edit").val();
        var moTa = $("#MoTaMucDoKho_Edit").val();
        var id = idEdit;

        if (tenMucDoKho === "" || moTa === "") {
            $.bootstrapGrowl("Số lượng mức độ khó không được để trống !", { type: 'warning' });
        }
        $.ajax({
            url: "/admin/SoLuongDoKho/Sua_MucDoKho",
            type: "POST",
            data: {
                id: id,
                tenMucDoKho: tenMucDoKho,
                moTa: moTa
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
