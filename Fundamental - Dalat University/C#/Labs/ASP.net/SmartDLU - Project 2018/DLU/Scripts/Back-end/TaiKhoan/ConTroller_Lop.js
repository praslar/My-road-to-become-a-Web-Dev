function ConTroller_Lop() {
    var ID_Delete = 0;
    function Load_DanhSachLop() {
        waitingDialog.show();
        $.ajax({
            url: "/admin/Lop/Get_Lop_ALL",
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
                                <td> `+ row.TenLop + ` </td>
                                <td> `+ row.MoTaLop + ` </td>
                                <td class ="text-center">
                                    <a href="#" class ="btn btn-success btn-xs btn-flat" onclick= "Lop.Modal_Create_Edit_Lop(`+ row.ID + `,'Update')" >Sửa</a>
                                     <a class ="btn btn-danger btn-xs btn-flat" onclick= "Lop.Modal_Delete_Lop(`+ row.ID + `)" >Xóa</a>
                                </td>
                               </tr>
                        `;

                });
                var table = $('#example_lop').DataTable();
                table.destroy();
                $("#data_Lop").html(HTML);

                $('#example_lop').DataTable({
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
    Load_DanhSachLop();
    this.Modal_Delete_Lop = function (ID) {
        ID_Delete = ID;
        $("#Modal_Delete_Lop").modal("show");
       
    }
    this.Delete_Lop = function () {
        $.ajax({
            url: "/admin/Lop/Delete_Lop",
            type: "POST",
            data: { ID_Delete: ID_Delete },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Load_DanhSachLop();
                    $.bootstrapGrowl("Xóa thành công ", { type: 'success' });
                    $("#Modal_Delete_Lop").modal("hide");
                } else {
                    $.bootstrapGrowl("Xóa không thành công ID đang được sử dụng", { type: 'danger' });
                    $("#Modal_Delete_Lop").modal("hide");
                }
            }
        })
    }
    this.Modal_Create_Edit_Lop = function (id, type) {
        if (type == "Add") {
            $(".btn_Add").show()
            $(".btn_Update").hide();
            $(".txt_title").text("Thêm lớp mới");
            $("#txtID").val("");
            $("#txtTenLop").val("");
            $("#txtMoTaLop").val("");
            $("#Modal_Create_Edit_Lop").modal("show");
        } else {
            $(".btn_Add").hide()
            $(".btn_Update").show();
            $(".txt_title").text("Chỉnh sửa lớp");
            $.ajax({
                url: "/admin/Lop/Get_Lop_ByID",
                type: "POST",
                data: { ID: id },
                dataType: "json",
                success: function (data) {
                    $.each(data.data, function (ID, item) {
                        $("#txtID").val(item.ID);
                        $("#txtTenLop").val(item.TenLop);
                        $("#txtMoTaLop").val(item.MoTaLop);
                   
                    });
                    $("#Modal_Create_Edit_Lop").modal("show");
                }
            })
        }
       
    }
    this.Create_Lop = function () {
        var TenLop = $("#txtTenLop").val();
        var MoTaLop = $("#txtMoTaLop").val();
        $.ajax({
            url: "/admin/Lop/Create_Lop",
            type: "POST",
            data: { TenLop: TenLop, MoTaLop: MoTaLop},
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Load_DanhSachLop();
                    $.bootstrapGrowl("Thêm thành công ", { type: 'success' });
                    $("#Modal_Create_Edit_Lop").modal("hide");
                }
            }
        })
    }
    this.Edit_Lop = function () {
        var ID = $("#txtID").val();
        var TenLop = $("#txtTenLop").val();
        var MoTaLop = $("#txtMoTaLop").val();
        $.ajax({
            url: "/admin/Lop/Edit_Lop",
            type: "POST",
            data: { ID:ID, TenLop: TenLop, MoTaLop: MoTaLop },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Load_DanhSachLop();
                    $.bootstrapGrowl("Sửa thành công ", { type: 'success' });
                    $("#Modal_Create_Edit_Lop").modal("hide");
                }
            }
        })
    }
}