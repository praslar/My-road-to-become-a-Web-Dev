function Controller_DanhSachThi() {
    function Get_HoTen(ID) {
        var HoTen = ``;
        $.ajax({
            url: "/admin/TaiKhoanSinhVien/Get_HoTen_TaiKhoanSinhVien",
            type: "POST",
            data: { ID: ID },
            dataType: "json",
            async: false,
            success: function (data) {
                HoTen = data.data;

            }
        });
        return HoTen;
    }
    this.Get_DanhSachLop_2 = function () {
        $.ajax({
            url: "/admin/TaiKhoanSinhVien/Get_DanhSachLop",
            type: "POST",
            dataType: "json",
            async: false,
            success: function (data) {
                HTML = ``;
                $.each(data.data, function (ID, item) {

                    HTML += `<option value="` + item.ID + `">` + item.TenLop + `</option>`;
                });
                $(".DanhSachLop2").html(HTML);

            }
        });
    }
    this.Get_LichThi = function () {
        $.ajax({
            url: "/admin/DanhSachThi/Get_LichThi",
            type: "POST",
            dataType: "json",
            async: false,
            success: function (data) {
                HTML = ``;
                $.each(data.data, function (ID, item) {
                    HTML += `<option value="` + item.IDLICHTHI + `">` + item.GIOTHI + ` / `+item.PHONGTHI+`</option>`;
                });
                $(".DanhSachLichThi").html(HTML);
            }
        });
    }
    function Get_DanhSachTaiKhoanSinhVien(IDLop, IDLichThi) {
        waitingDialog.show();
        $.ajax({
            url: "/admin/DanhSachThi/Get_DanhSachTaiKhoanLichThi",
            type: "POST",
            data: { IDLop: IDLop, IDLichThi: IDLichThi },
            dataType: "json",
            async: false,
            success: function (data) {
                waitingDialog.hide();
                console.log(data.data);
                var HTML = ``;
                var i = 0;
                $.each(data.data, function (ID, item) {
                    i++;
                    HTML += `
                        <tr>
                            <td><label> <input type="checkbox" class ="minimal"></label></td>
                            <td> `+ i + ` </td>
                            <td> `+ Get_HoTen(item.ID) + ` </td>
                            <td> `+ item.TenDangNhap + ` / `+item.MatKhau+ `</td>
                            <td class ="text-center">
                                <button class ="btn btn-success btn-xs btn-flat" onclick= "TaiKhoanSinhVien.Modal_Them_Sua_TaiKhoanLichThi('update',`+ item.ID + `)" >Sửa</button>
                                <button class ="btn btn-danger btn-xs btn-flat" onclick= "TaiKhoanSinhVien.Modal_Delete(`+ item.ID + `)" >Xóa</button>
                            </td>
                        </tr>
                      `;
                });
                var table = $('#example2').DataTable();
                table.destroy();
                $("#data_tkSinhVienThi").html(HTML);
                $('#example2').DataTable({
                    'paging': false,
                    'lengthChange': false,
                    'searching': true,
                    'ordering': true,
                    'info': false,
                    "scrollY": 300,
                });
                $('input[type="checkbox"].minimal, input[type="radio"].minimal').iCheck({
                    checkboxClass: 'icheckbox_minimal-blue',
                    radioClass: 'iradio_minimal-blue'
                })

               
            }
        });

    }
    this.Load_DanhSachTaiKhoanLichThi = function () {
        var IDLop =$(".DanhSachLop2").val();
        var IDLichThi =$(".DanhSachLichThi").val();
        Get_DanhSachTaiKhoanSinhVien(IDLop, IDLichThi);
    }
    this.TimKiemTaiKhoanLichThi = function () {
        var IDLop = $(".DanhSachLop2").val();
        var IDLichThi = $(".DanhSachLichThi").val();
        Get_DanhSachTaiKhoanSinhVien(IDLop, IDLichThi);
    }
    function Get_DanhSachTaiKhoanSinhVien_IDLop(key) {
        $.ajax({
            url: "/admin/TaiKhoanSinhVien/Get_DanhSachTaiKhoanSinhVien",
            type: "POST",
            data: { key: key },
            dataType: "json",
          
            success: function (data) {
                var HTML = ``;
                var i = 0;
                $.each(data.data, function (ID, item) {
                    i++;
                    HTML += `
                        <tr>
                            <td><label> <input type="checkbox" class ="minimal"></label></td>
                            <td> `+ i + ` </td>
                            <td> `+ item.TenDangNhap + ` </td>
                            <td> `+ item.MatKhau + ` </td>
                            <td> `+ Get_HoTen(item.ID) + ` </td>
                            <td> `+ item.Email + ` </td>
                        </tr>
                      `;
                });
                var table = $('#DanhSachTKLOP').DataTable();
                table.destroy();
                $("#Modal_Create_Edit_DanhSachThi").modal("show");
                $("#data_tkSinhVien_Lop").html(HTML);
                $('#DanhSachTKLOP').DataTable({
                    'paging': true,
                    'lengthChange': true,
                    'searching': true,
                    'ordering': true,
                    'info': false,
                   // "scrollY": 200,
                   
                });
                $('input[type="checkbox"].minimal, input[type="radio"].minimal').iCheck({
                    checkboxClass: 'icheckbox_minimal-blue',
                    radioClass: 'iradio_minimal-blue'
                })
            }
        });

    }
    this.Modal_Them_Sua_TaiKhoanLichThi = function (ID,type) {
        Get_DanhSachTaiKhoanSinhVien_IDLop(0);
    }
   
   
   
} 