function Controller_DoKho() {
    var id;
    var idEdit;


    //Modal Create
    this.Modal_CreateDoKho = function() {
        $("#Modal_Create").modal("show");
        $.ajax({
            url: "/admin/DoKho/Get_SoLuongDoKho",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDMUCDOKHO + `">` + item.TENMUCDOKHO + `</option>`;
                    });
                $("#MucDoKho").html(html);
            }
        });
    };



    //Create function
    this.Create_DoKho = function() {
        var tenDoKho = $("#TenDoKho").val();
        var idSoLuongDoKho = $("#MucDoKho").val();

        if (tenDoKho === "" || idSoLuongDoKho === "") {
            $.bootstrapGrowl("Tên độ khó và số lượng mức độ khó không được để trống !", { type: 'warning' });
        } else {
            $.ajax({
                url: "/admin/DoKho/Them_DoKho",
                type: "POST",
                data: {
                    tenDoKho: tenDoKho,
                    IDSoLuongDoKho: idSoLuongDoKho
                },
                dataType: "json",
                success: function(data) {
                    if (data.data === true) {

                        location.reload();

                    } else if (data.data === "invalidDoKho") {
                        $.bootstrapGrowl("Quá số lượng độ khó cho phép!", { type: 'warning' });
                    } else {
                        $.bootstrapGrowl("Độ khó đã tồn tại!!", { type: 'warning' });
                    }
                }
            });
        }
    };
    //Modal Delete
    this.Modal_DeleteDoKho = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_DoKho = function() {
        $.ajax({
            url: "/admin/DoKho/Xoa_DoKho?ID=" + id,
            type: "POST",
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Không thể xóa! Còn tồn tại dữ liệu sử dụng độ khó này", { type: 'warning' });
                }
            }
        });
    };

    //Modal Edit
    this.Modal_EditDoKho = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        $.ajax({
            url: "/admin/DoKho/Get_SoLuongDoKho",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDMUCDOKHO + `">` + item.TENMUCDOKHO + `</option>`;
                    });
                $("#MucDoKho_Edit").html(html);
            }
        });
        // Không lấy được sldokho theo id do kho
        //$.ajax({
        //    url: "/admin/DoKho/Get_CurrentSoLuongDoKho?ID=" + t,
        //    type: "POST",
        //    dataType: "json",
        //    success: function (data) {
        //        console.log(data);
        //        $.each(data.data, function (ID, item) {

        //            $("#MucDoKho_Edit").val(item.IDMUCDOKHO);
        //        });
        //    }
        //})

        $.ajax({
            url: "/admin/DoKho/Get_DoKho?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $.each(data.data,
                    function(id, item) {
                        $("#TenDoKho_Edit").val(item.TENDOKHO);
                    });
            }
        });
    };
    //Edit function
    this.Edit_DoKho = function() {
        var tenDoKho = $("#TenDoKho_Edit").val();
        var idSoLuongDoKho = $("#MucDoKho_Edit").val();
        var id = idEdit;

        if (tenDoKho === "" || idSoLuongDoKho === "") {
            $.bootstrapGrowl("Tên độ khó và số lượng mức độ khó không được để trống !", { type: 'warning' });
        }

        $.ajax({
            url: "/admin/DoKho/Sua_DoKho",
            type: "POST",
            data: {
                id: id,
                tenDoKho: tenDoKho,
                IDSoLuongDoKho: idSoLuongDoKho
            },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Độ khó đã tồn tại!", { type: 'warning' });
                }
            }
        });
    };
}
