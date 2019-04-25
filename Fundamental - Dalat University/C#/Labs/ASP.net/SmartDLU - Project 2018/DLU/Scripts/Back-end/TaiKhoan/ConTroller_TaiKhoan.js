function ConTroller_TaiKhoan() {
    var ID;
    var ID_Edit;
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
    function Admin(MaCV,ID) {
        var HTML = ``;
        if (MaCV == 'AD') {
            HTML += `<button class ="btn btn-danger btn-xs btn-flat" title="Không thể xóa" disabled onclick= "TaiKhoan.Modal_Delete(` + ID + `)" ><i class="fa fa-trash-o" aria-hidden="true"></i></button>`
        } else {
            HTML += `<button class ="btn btn-danger btn-xs btn-flat" title="Xóa" onclick= "TaiKhoan.Modal_Delete(` + ID + `)" ><i class="fa fa-trash-o" aria-hidden="true"></i></button>`
        }
        return HTML;
    }
    function Get_DanhSachTaiKhoan(key) {
        
        waitingDialog.show();
        $.ajax({
            url: "/admin/TaiKhoan/Get_DanhSachTaiKhoan",
            type: "POST",
            data: { MaCV: key },
            dataType: "json",
            success: function (data) {
              
                waitingDialog.hide();
                var HTML = ``;
                var i = 0;
                $.each(data.data, function (ID, item) {
                    i++;
                    HTML += `
                        <tr>
                            <td> `+ i + ` </td>
                            <td> `+ item.TenDangNhap + ` </td>
                            
                            <td> `+ Get_HoTen(item.ID) + ` </td>
                            <td> `+ item.Email + ` </td>
                            <td class ="text-center">
                                <button class ="btn btn-info btn-xs btn-flat" title="Xem chi tiết"   onclick= "TaiKhoan.Modal_View_Details_TaiKhoan(`+ item.ID + `)" ><i class ="fa fa-eye" aria-hidden="true"></i></button>
                                <button class ="btn btn-success btn-xs btn-flat" title="Chỉnh sửa" onclick= "TaiKhoan.Modal_Create_Edit_TaiKhoan('update',`+ item.ID + `)" ><i class ="fa fa-pencil-square" aria-hidden="true"></i></button>
                                `+Admin(item.MaCV,item.ID)+`
                               
                            </td>
                        </tr>
                      `;
                });
                var table = $('#example_TaiKhoan').DataTable();
                table.destroy();
                $("#data_TaiKhoan").html(HTML);
                $('#example_TaiKhoan').DataTable({
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
    Get_DanhSachTaiKhoan('ALL');
    this.TimKiemTheoMaCV = function () {
        Get_DanhSachTaiKhoan($(".DanhSachChuCVu").val());
    }
    this.Modal_View_Details_TaiKhoan = function (t) {
        $("#Modal_View_Details_TaiKhoan").modal("show");
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
    this.Ckeck_Mail = function () {
        $("#Mail").keyup(function () {
            var Mail = $("#Mail").val();
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
                            $(".id_ckeckMail").removeClass("has-success")

                        } else {
                            $("#msg_html").html(`<label class="control-label" for="inputError"><i class="fa fa-check"></i>Mail này có thể sử dụng </label> `)
                            $(".id_ckeckMail").addClass("has-success");
                            $(".id_ckeckMail").removeClass("has-error")
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
    this.Modal_Create_Edit_TaiKhoan = function (type, t) {
        if (type == "add") {
            $(".AnHien").attr("disabled", false);
            $(".txt_TaiKhoan").text("Thêm mới tài khoản");

            $("#msg_html_TenDangNhap").html("");
            $(".id_TenDangNhap").removeClass("has-error");
            $(".id_TenDangNhap").removeClass("has-success");

            $("#msg_html").html("");
            $(".id_ckeckMail").removeClass("has-error");
            $(".id_ckeckMail").removeClass("has-success");


            $("#TenDangNhap").val("");
            $("#MatKhau").val("");
            $("#Mail").val("");
            $("#Ho").val("");
            $("#Ten").val("");
            $("#NgaySinh").val("");
            $("#SoCMND").val("");
            $("#DiaChi").val("");
            $("#Modal_Them_Sua_TaiKhoan").modal("show");
            $(".ADD").show();
            $(".UPDATE").hide();
        }
        else {
            $(".txt_TaiKhoan").text("Chỉnh sửa tài khoản");
            $(".AnHien").attr("disabled", false);
            $(".ADD").hide();
            $(".UPDATE").show();

            $("#msg_html_TenDangNhap").html("");
            $(".id_TenDangNhap").removeClass("has-error");
            $(".id_TenDangNhap").removeClass("has-success")

            $("#msg_html").html("");
            $(".id_ckeckMail").removeClass("has-error");
            $(".id_ckeckMail").removeClass("has-success");


            ID_Edit = t;
            $.ajax({
                url: "/admin/TaiKhoan/Get_TaiKhoan_Va_ThongTin",
                type: "POST",
                data: { ID: t },
                dataType: "json",
                success: function (data) {
                    console.log(data);
                    $("#Modal_Them_Sua_TaiKhoan").modal("show");
                    if (data.TK != null) {
                        $.each(data.TK, function (i, item) {
                            $("#TenDangNhap").val(item.TenDangNhap);
                            $("#MatKhau").val(item.MatKhau);
                            $("#ChucVu option[value=" + item.MaCV + "]").attr("selected", !0)
                            $("#Mail").val(item.Email);
                            $.each(data.TT, function (x, TT) {
                                $("#Ho").val(TT.Ho);
                                $("#Ten").val(TT.Ten);
                                $("#NgaySinh").val(TT.NgaySinh);
                                $("#SoCMND").val(TT.SoCMND);
                                $("#DiaChi").val(TT.DiaChi);

                                var html = ``;
                                if (TT.GioiTinh == true) {
                                    html = `<label for="exampleInputPassword1">Giới Tính</label>
                                        <br />
                                        <label>
                                            <input type="radio" name="radio" value="true" class ="minimal" checked> Nam
                                        </label>
                                        <label>
                                            <input type="radio" name="radio" value="false" class ="minimal" > Nữ
                                        </label>`;
                                    $(".doiradio").html(html);
                                }
                                else {
                                    html = `<label for="exampleInputPassword1">Giới Tính</label>
                                        <br />
                                        <label>
                                            <input type="radio" name="radio" value="true" class ="minimal" > Nam
                                        </label>
                                        <label>
                                            <input type="radio" name="radio" value="false" class ="minimal" checked> Nữ
                                        </label>`;
                                    $(".doiradio").html(html);
                                }
                            })


                        })
                    }

                }
            })
        }
    }
    this.Them_TaiKhoan = function () {
        waitingDialog.show();
        var TenDangNhap = $("#TenDangNhap").val();
        var MatKhau = $("#MatKhau").val();
        var ChucVu = $("#ChucVu").val();
        var Mail = $("#Mail").val();
        var Ho = $("#Ho").val();
        var Ten = $("#Ten").val();
        var NgaySinh = $("#NgaySinh").val();
        var GioiTinh = $("input[name='radio']:checked").val();
        var SoCMND = $("#SoCMND").val();
        var DiaChi = $("#DiaChi").val();
        var HinhAnh = "";
        if (TenDangNhap == "" || MatKhau == "") {
            $.bootstrapGrowl("Tên đăng nhập và mật khẩu không được để trống !", { type: 'warning' });
        }
        else {
            $.ajax({
                url: "/admin/TaiKhoan/Them_TaiKhoan",
                type: "POST",
                data: {
                    TenDangNhap: TenDangNhap,
                    MatKhau: MatKhau,
                    ChucVu: ChucVu,
                    Mail: Mail,
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

                        Get_DanhSachTaiKhoan($(".DanhSachChuCVu").val());
                        $("#Modal_Them_Sua_TaiKhoan").modal("hide");
                        $.bootstrapGrowl("Thêm thành công !", { type: 'success' });

                    }
                }
            })
        }

    }
    this.Edit_HoSo = function () {
        waitingDialog.show();
        var TenDangNhap = $("#TenDangNhap").val();
        var MatKhau = $("#MatKhau").val();
        var ChucVu = $("#ChucVu").val();
        var Mail = $("#Mail").val();
        var Ho = $("#Ho").val();
        var Ten = $("#Ten").val();
        var NgaySinh = $("#NgaySinh").val();
        var GioiTinh = $("input[name='radio']:checked").val();
        var SoCMND = $("#SoCMND").val();
        var DiaChi = $("#DiaChi").val();
        var HinhAnh = "";
        $.ajax({
            url: "/admin/TaiKhoan/Edit_HoSo",
            type: "POST",
            data: {
                ID: ID_Edit,
                TenDangNhap: TenDangNhap,
                MatKhau: MatKhau,
                Email: Mail,
                MaCV: ChucVu,
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
                    Get_DanhSachTaiKhoan($(".DanhSachChuCVu").val());
                    $("#Modal_Them_Sua_TaiKhoan").modal("hide");
                    $.bootstrapGrowl("Sửa thành công !", { type: 'success' });
                }
            }
        })

    }
    this.Modal_Delete = function (t) {
        ID = t;
        $("#Modal_Delete").modal("show");
    }
    this.Delete_TaiKhoan = function () {
        waitingDialog.hide();
        $.ajax({
            url: "/admin/TaiKhoan/Xoa_TaiKhoan",
            type: "POST",
            data: { ID: ID },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    waitingDialog.hide();
                    Get_DanhSachTaiKhoan($(".DanhSachChuCVu").val());
                    $("#Modal_Delete").modal("hide");
                    $.bootstrapGrowl("Xóa thành công !", { type: 'success' });
                }
                else {
                    $("#Modal_Delete").modal("hide");
                    $.bootstrapGrowl("Xóa không thành công ID đang được sử dụng", { type: 'danger' });
                }
            }
        })
    }
}