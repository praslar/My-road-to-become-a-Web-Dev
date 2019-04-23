function Controller_TaiKhoanSinhVien() {
   
    var ID;
    this.Get_DanhSachLop=function()
    {
        $.ajax({
            url: "/admin/Lop/Get_Lop_ALL",
            type: "POST",
            dataType: "json",
            async: false,
            success: function (data) {
                HTML = `<option value="0">Tất cả</option>`;
                $.each(data.data, function (ID, item) {

                    HTML += `<option value="`+item.ID+`">`+item.TenLop+`</option>`;
                });
                $("#DanhSachLop").html(HTML);
                
            }
        });
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
                $("#DanhSachLop2").html(HTML);

            }
        });
    }
    function Get_HoTen(ID)
    {
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
    function Get_DanhSachTaiKhoanSinhVien(key) {
        waitingDialog.show();
        $.ajax({
            url: "/admin/TaiKhoanSinhVien/Get_DanhSachTaiKhoanSinhVien",
            type: "POST",
            data: { key: key },
            dataType: "json",
            success: function (data) {
                waitingDialog.hide();
                var HTML = ``;
                var i = 0;
                $.each(data.data, function (ID, item) {
                    i++;
                    HTML += `
                        <tr>
                            <td> `+i+` </td>
                            <td> `+item.TenDangNhap+` </td>
                            <td> `+item.MatKhau+` </td>
                            <td> `+Get_HoTen(item.ID)+` </td>
                            <td> `+item.Email+` </td>
                            <td class ="text-center">
                                <button class ="btn btn-info btn-xs btn-flat" title="Xem chi tiết" onclick= "TaiKhoanSinhVien.Modal_View_TaiKhoanSinhVien(`+item.ID+`)" ><i class ="fa fa-eye" aria-hidden="true"></i></button>
                                <button class ="btn btn-success btn-xs btn-flat" title="Chỉnh sửa" onclick= "TaiKhoanSinhVien.Modal_Create_Edit('update',`+item.ID+`)" ><i class ="fa fa-pencil-square" aria-hidden="true"></i></button>
                                <button class ="btn btn-danger btn-xs btn-flat" title="Xóa" onclick= "TaiKhoanSinhVien.Modal_Delete(`+item.ID+`)" ><i class ="fa fa-trash-o" aria-hidden="true"></i></button>
                            </td>
                        </tr>
                      `;
                });            
                var table = $('#TaiKhoanSinhVien').DataTable();
                table.destroy();
                $("#data_TaiKhoanSinhVien").html(HTML);
                $('#TaiKhoanSinhVien').DataTable({
                    'paging': false,
                    'lengthChange': false,
                    'searching': true,
                    'ordering': true,
                    'info': true,
                    "scrollY": 300,
                });
            }
        });
    }
    Get_DanhSachTaiKhoanSinhVien(0);
    this.TimKiemTheoLop = function () {
        Get_DanhSachTaiKhoanSinhVien($(".DanhSachLop").val());
    }
    this.Ckeck_Mail = function () {
        $("#Email").keyup(function () {
            var Mail = $("#Email").val();
            if (Mail == "") {
                $("#msg_html").html("");
                $(".id_ckeckMail").removeClass("has-success");
                $(".id_ckeckMail").removeClass("has-error");
            }
            else {
                $.ajax({
                    url: "/admin/TaiKhoan/Ckeck_Mail",
                    type: "POST",
                    data: { Mail: Mail },
                    dataType: "json",
                    success: function (data) {
                        if (data.data == true) {
                            $("#msg_html").html(` <label class="control-label" for="inputError"><i class="fa fa-times-circle-o"></i> Mail đang được sử dụng vui lòng nhập mail khác !</label> `)
                            $(".id_ckeckMail").addClass("has-error");
                            $(".id_ckeckMail").removeClass("has-success");
                            $(".AnHien").attr("disabled", true);

                        } else {
                            $("#msg_html").html(`<label class="control-label" for="inputError"><i class="fa fa-check"></i>Mail này có thể sử dụng </label> `)
                            $(".id_ckeckMail").addClass("has-success");
                            $(".id_ckeckMail").removeClass("has-error")
                            $(".AnHien").attr("disabled", false);
                        }
                    }
                })
            }

        })
    }
    this.Ckeck_TenDangNhap = function () {
        $("#TenDangNhap").keyup(function () {

            var TenDangNhap = $("#TenDangNhap").val();
            if (TenDangNhap == "") {
                $("#msg_html_TenDangNhap").html("");
                $(".id_TenDangNhap").removeClass("has-success");
                $(".id_TenDangNhap").removeClass("has-error");
            }
            else {
                $.ajax({
                    url: "/admin/TaiKhoan/Ckeck_TenDangNhap",
                    type: "POST",
                    data: { TenDangNhap: TenDangNhap },
                    dataType: "json",
                    success: function (data) {
                        if (data.data == true) {
                            $("#msg_html_TenDangNhap").html(` <label class="control-label" for="inputError"><i class="fa fa-times-circle-o"></i> Tên đăng nhập đang được sử dụng vui lòng nhập tên khác !</label> `)
                            $(".id_TenDangNhap").addClass("has-error");
                            $(".id_TenDangNhap").removeClass("has-success")
                            $(".AnHien").attr("disabled", true);

                        } else {
                            $("#msg_html_TenDangNhap").html(`<label class="control-label" for="inputError"><i class="fa fa-check"></i>Tên đăng nhập này có thể sử dụng </label> `)
                            $(".id_TenDangNhap").addClass("has-success");
                            $(".id_TenDangNhap").removeClass("has-error")
                            $(".AnHien").attr("disabled", false);
                        }
                    }
                })
            }

        })
    }
    this.Modal_Delete = function (t) {
        ID = t;
        $("#Modal_Delete").modal("show");
    }
    this.Delete_TaiKhoanSinhVien = function () {
        $("#Modal_Delete").modal("hide");
        waitingDialog.show();
        $.ajax({
            url: "/admin/TaiKhoanSinhVien/Delete_taiKhoanSinhVien",
            type: "POST",
            data: { ID: ID },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    Get_DanhSachTaiKhoanSinhVien($("#DanhSachLop").val());
                    $("#Modal_Delete").modal("hide");
                    $.bootstrapGrowl("Xóa thành công !", { type: 'success' });
                   
                } else {
                    $("#Modal_Delete").modal("hide");
                    $.bootstrapGrowl("Xóa không thành công ID đang được sử dụng ", { type: 'danger' });
                   
                }
            }
        })
    }
    this.Modal_Create_Edit = function (type, t) {
        if (type == "add") {
            $(".AnHien").attr("disabled", false);
            $(".txt_TaiKhoan").text("Thêm mới tài khoản sinh viên");

            $("#msg_html_TenDangNhap").html("");
            $(".id_TenDangNhap").removeClass("has-error");
            $(".id_TenDangNhap").removeClass("has-success");

            $("#msg_html").html("");
            $(".id_ckeckMail").removeClass("has-error");
            $(".id_ckeckMail").removeClass("has-success");

            $(".TenDangNhap").val("");
            $(".MatKhau").val("");
            $(".Email").val("");
            $(".Ho").val("");
            $(".Ten").val("");
            $(".NgaySinh").val("");
            $(".SoCMND").val("");
            $(".DiaChi").val("");
            $("#Edit").hide();
            $("#Add").show();
            $("#Modal_Edit_Create_TaiKhoanSinhVien").modal("show");
            $.ajax({
                url: "/admin/Nhom/Get_Nhom_ALL",
                type: "POST",
                dataType: "json",
                success: function (data) {
                    var HTML = ``
                    $.each(data.data, function (ID, item) {
                        HTML += `<option value="` + item.ID + `">` + item.TenNhom + `</option>`;
                    });
                    $(".DanhSachNhomTaiKhoan").html(HTML);
                    load();
                }
            })
        } else {
            $(".AnHien").attr("disabled", false);
            $(".txt_TaiKhoan").text("Chỉnh sửa tài khoản sinh viên");

            $("#msg_html_TenDangNhap").html("");
            $(".id_TenDangNhap").removeClass("has-error");
            $(".id_TenDangNhap").removeClass("has-success");

            $("#msg_html").html("");
            $(".id_ckeckMail").removeClass("has-error");
            $(".id_ckeckMail").removeClass("has-success");

            $("#Edit").show();
            $("#Add").hide();
            $.ajax({
                url: "/admin/TaiKhoanSinhVien/Get_TK_TKN_TTTK",
                type: "POST",
                data: { ID: t },
                dataType: "json",
                success: function (data) {
                    if (data.TK != null) {
                        $.each(data.TK, function (i, item) {
                            $(".IDTaiKhoan").val(item.ID);
                            $(".TenDangNhap").val(item.TenDangNhap);
                            $(".MatKhau").val(item.MatKhau);
                            $(".Email").val(item.Email);
                            console.log(data.TK);
                            console.log(item.IDLop);
                            $("#DanhSachLop2 option[value=" + item.IDLop + "]").attr("selected", !0)
                            $.each(data.TT, function (x, TT) {
                                $(".Ho").val(TT.Ho);
                                $(".Ten").val(TT.Ten);
                                $(".NgaySinh").val(TT.NgaySinh);
                                $(".SoCMND").val(TT.SoCMND);
                                $(".DiaChi").val(TT.DiaChi);
                                var html = ``;
                                if (TT.GioiTinh == true) {
                                    html = `<label for="exampleInputPassword1">Giới Tính</label>
                                        <br />
                                        <label>
                                            <input type="radio" name="RADIO" value="true" class ="minimal" checked> Nam
                                        </label>
                                        <label>
                                            <input type="radio" name="RADIO" value="false" class ="minimal" > Nữ
                                        </label>`;
                                    $(".doiradio").html(html);
                                }
                                else {
                                    html = `<label for="exampleInputPassword1">Giới Tính</label>
                                        <br />
                                        <label>
                                            <input type="radio" name="RADIO" value="true" class ="minimal" > Nam
                                        </label>
                                        <label>
                                            <input type="radio" name="RADIO" value="false" class ="minimal" checked> Nữ
                                        </label>`;
                                    $(".doiradio").html(html);
                                }
                            });
                        });
                        $("#Modal_Edit_Create_TaiKhoanSinhVien").modal("show");
                    }
                }
            });

        }

    }
    this.Them_TaiKhoanSinhVien = function () {
        var TenDangNhap = $(".TenDangNhap").val();
        var MatKhau =     $(".MatKhau").val();
        var ChucVu =       "SV";
        var IDLop = $(".DanhSachLop2").val();
        var Email = $(".Email").val();
      
        var Ho = $(".Ho").val();
        var Ten = $(".Ten").val();
        var NgaySinh = $(".NgaySinh").val();
        var GioiTinh = $("input[name='RADIO']:checked").val();
        var SoCMND = $(".SoCMND").val();
        var DiaChi = $(".DiaChi").val();
        var HinhAnh = "";
        if (TenDangNhap == "" || MatKhau == "") {
            $.bootstrapGrowl("Tên đăng nhập và mật khẩu không được để trống !", { type: 'warning' });
        }  
        else {
            $.ajax({
                url: "/admin/TaiKhoanSinhVien/Them_TaiKhoanSinhVien",
                type: "POST",
                data: {
                    TenDangNhap: TenDangNhap,
                    MatKhau: MatKhau,
                    ChucVu: ChucVu,
                    IDLop: IDLop,
                    Email: Email,
                    Ho: Ho,
                    Ten: Ten,
                    NgaySinh: NgaySinh,
                    GioiTinh: GioiTinh,
                    SoCMND: SoCMND,
                    DiaChi: DiaChi,
                    HinhAnh:HinhAnh
                   
                },
                dataType: "json",
                success: function (data) {
                    if (data.data == true) {
                        Get_DanhSachTaiKhoanSinhVien($("#DanhSachLop").val());
                        $("#Modal_Edit_Create_TaiKhoanSinhVien").modal("hide");
                        $.bootstrapGrowl("Thêm thành công", { type: 'success' });
                    }
                }
            });
        }
    }
    this.Edit_TaiKhoanSinhVien = function () {
        waitingDialog.show("Loading", {
            dialogSize: "sm",
            progressType: "primary"
        });
        var IDTaiKhoan = $(".IDTaiKhoan").val();
        var TenDangNhap = $(".TenDangNhap").val();
        var MatKhau = $(".MatKhau").val();
        var ChucVu = "SV";
        var IDLop = $(".DanhSachLop2").val();
        var Email = $(".Email").val();
        var Ho = $(".Ho").val();
        var Ten = $(".Ten").val();
        var NgaySinh = $(".NgaySinh").val();
        var GioiTinh = $("input[name='RADIO']:checked").val();
        var SoCMND = $(".SoCMND").val();
        var DiaChi = $(".DiaChi").val();
        var HinhAnh = "";
        if (TenDangNhap == "" || MatKhau == "") {
            $.bootstrapGrowl("Tên đăng nhập và mật khẩu không được để trống !", { type: 'warning' });
        } else if (Email == '') {
            $.bootstrapGrowl("Email không được để trống !", { type: 'warning' });
        }
        else {
            $.ajax({
                url: "/admin/TaiKhoanSinhVien/Sua_TaiKhoanSinhVien",
                type: "POST",
                data: {
                    IDTaiKhoan:IDTaiKhoan,
                    TenDangNhap: TenDangNhap,
                    MatKhau: MatKhau,
                    ChucVu: ChucVu,
                    IDLop: IDLop,
                    Email: Email,
                    Ho: Ho,
                    Ten: Ten,
                    NgaySinh: NgaySinh,
                    GioiTinh: GioiTinh,
                    SoCMND: SoCMND,
                    DiaChi: DiaChi,
                    HinhAnh: HinhAnh

                },
                dataType: "json",
                success: function (data) {
                    if (data.data == true) {

                       
                        $("#Modal_Edit_Create_TaiKhoanSinhVien").modal("hide");
                        $.bootstrapGrowl("Sửa thành công", { type: 'success' });
                        Get_DanhSachTaiKhoanSinhVien($("#DanhSachLop").val());
                    }
                }
            });
        }

    }
    this.Modal_View_TaiKhoanSinhVien = function (t) {
        $("#Modal_View_Details_TaiKhoanSinhVien").modal("show");
        $.ajax({
            url: "/admin/HoSo/Xem_ThongTinTaiKhoan",
            type: "POST",
            data: { ID: t },
            dataType: "json",
            success: function (data) {
                $.each(data.data, function (ID, item) {
                    $(".Ho_View").text(item.Ho);
                    $(".Ten_View").text(item.Ten);
                    $(".NgaySinh_View").text(item.NgaySinh);
                    var GT = item.GioiTinh == false ? 'Nữ' : 'Nam';
                    $(".GiioTinh_View").text(GT);
                    $(".SoCMND_View").text(item.SoCMND);
                    $(".DiaChi_View").text(item.DiaChi);
                });
            }
        })
    }
}
