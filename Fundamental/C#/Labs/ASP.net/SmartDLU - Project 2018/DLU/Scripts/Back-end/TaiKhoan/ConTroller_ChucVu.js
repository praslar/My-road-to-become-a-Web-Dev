function ConTroller_ChucVu() {
    this.Get_All_DanhSach_ChucVu=function()
    {
        $.ajax({
            url: "/admin/ChucVu/Get_List_ChucVu",
            type: "POST",
            dataType: "json",
            success: function (data) {
                var HTML = ``
                $.each(data.data, function (ID, item) {
                    HTML += `<option value="` + item.MaCV + `">` + item.TenCV + `</option>`;
                });
                $(".MaCV").html(HTML);
           
            }
        })
    }
    this.Get_All_DanhSach_ChucVu_2 = function () {
        $.ajax({
            url: "/admin/ChucVu/Get_List_ChucVu",
            type: "POST",
            dataType: "json",
            success: function (data) {
                var HTML = `<option value="ALL">Tất cả</option>`;
                $.each(data.data, function (ID, item) {
                    HTML += `<option value="` + item.MaCV + `">` + item.TenCV + ` / ` + item.MoTaCV + `</option>`;
                });
                $(".DanhSachChuCVu").html(HTML);

            }
        })
    }
    var ID_Delete = 0;
    function Load_DanhSachChucVu() {
        waitingDialog.show();
        $.ajax({
            url: "/admin/ChucVu/Get_List_ChucVu",
            type: "POST",
            dataType: "json",
            success: function (data) {
                var HTML = ``;
                var i = 0;
                $.each(data.data, function (ID, row) {
                    i++;
                    HTML += `
                            <tr>
                                <th class ="text-center"> `+ i + ` </th>
                                 <td> `+ row.MaCV + ` </td>
                                <td> `+ row.TenCV + ` </td>
                                <td> `+ row.MoTaCV + ` </td>
                                <td class ="text-center">
                                    <a href="#" class ="btn btn-success btn-xs btn-flat" onclick= "ChucVu.Modal_Create_Edit_ChucVu(`+ row.ID + `,'Update')" >Sửa</a>
                                     <a class ="btn btn-danger btn-xs btn-flat" onclick= "ChucVu.Modal_Delete_ChucVu(`+ row.ID + `)" >Xóa</a>
                                </td>
                               </tr>
                        `;

                });
                var table = $('#example_ChucVu').DataTable();
                table.destroy();
                $("#data_ChucVu").html(HTML);

                $('#example_ChucVu').DataTable({
                    'paging': false,
                    'lengthChange': false,
                    'searching': true,
                    'ordering': true,
                    'info': true,
                    "scrollY": 300,
                });
                waitingDialog.hide()
            }
        });
    }
    Load_DanhSachChucVu();
    this.Modal_Delete_ChucVu = function (ID) {
        ID_Delete = ID;
        $("#Modal_Delete_ChucVu").modal("show");

    }
    this.Delete_ChucVu = function () {
        $.ajax({
            url: "/admin/ChucVu/Delete_ChucVu",
            type: "POST",
            data: { ID: ID_Delete },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Load_DanhSachChucVu();
                    $.bootstrapGrowl("Xóa thành công ", { type: 'success' });
                    $("#Modal_Delete_ChucVu").modal("hide");
                } else {
                    $.bootstrapGrowl("Xóa không thành công ID đang được sử dụng", { type: 'danger' });
                    $("#Modal_Delete_ChucVu").modal("hide");
                }
            }
        })
    }
    this.Modal_Create_Edit_ChucVu = function (id, type) {
        if (type == "Add") {
            $(".AnHienMaCV").show();
            $(".btn_Add").show()
            $(".btn_Update").hide();
            $(".txt_title").text("Thêm chức vụ mới");
            $("#txtID").val("");
            $("#txtMaCV").val("");
            $("#txtTenChucVu").val("");
            $("#txtMoTaChucVu").val("");
            $("#Modal_Create_Edit_ChucVu").modal("show");
        } else {
            $(".AnHienMaCV").hide();
            $(".btn_Add").hide()
            $(".btn_Update").show();
            $(".txt_title").text("Chỉnh sửa chức vụ");
            $.ajax({
                url: "/admin/ChucVu/Get_ChucVu_ByID",
                type: "POST",
                data: { ID: id },
                dataType: "json",
                success: function (data) {
                    $.each(data.data, function (ID, item) {
                        $("#txtID").val(item.ID);
                        $("#txtMaCV").val(item.MaCV);
                        $("#txtTenChucVu").val(item.TenCV);
                        $("#txtMoTaChucVu").val(item.MoTaCV);

                    });
                    $("#Modal_Create_Edit_ChucVu").modal("show");
                }
            })
        }

    }
    this.Create_ChucVu = function () {
        var MaCV = $("#txtMaCV").val();
        var TenCV = $("#txtTenChucVu").val();
        var MoTaCV = $("#txtMoTaChucVu").val();
        $.ajax({
            url: "/admin/ChucVu/Create_ChucVu",
            type: "POST",
            data: { MaCV: MaCV, TenCV: TenCV, MoTaCV: MoTaCV },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Load_DanhSachChucVu();
                    $.bootstrapGrowl("Thêm thành công ", { type: 'success' });
                    $("#Modal_Create_Edit_ChucVu").modal("hide");
                }
            }
        })
    }
    this.Edit_ChucVu = function () {
        var ID = $("#txtID").val();
        var MaCV = $("#txtMaCV").val();
        var TenCV = $("#txtTenChucVu").val();
        var MoTaCV = $("#txtMoTaChucVu").val();
        $.ajax({
            url: "/admin/ChucVu/Edit_ChucVu",
            type: "POST",
            data: { ID: ID, MaCV: MaCV, TenCV: TenCV, MoTaCV: MoTaCV },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Load_DanhSachChucVu();
                    $.bootstrapGrowl("Sửa thành công ", { type: 'success' });
                    $("#Modal_Create_Edit_ChucVu").modal("hide");
                }
            }
        })
    }
}