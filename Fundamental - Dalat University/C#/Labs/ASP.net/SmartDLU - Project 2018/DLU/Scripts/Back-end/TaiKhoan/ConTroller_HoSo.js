function ConTroller_HoSo()
{
    this.Active = function () {
        $(".xem_ho_so").addClass("active");
    }
    this.Edit_HoSo=function()
    {
        
        var ID = $("#ID").val();
        var Ho = $("#Ho").val();
        var Ten = $("#Ten").val();
        var NgaySinh = $("#NgaySinh").val();
        var GioiTinh = $("input[name='r1']:checked").val();
        var SoCMND = $("#SoCMND").val();
        var DiaChi = $("#DiaChi").val();
        var HinhAnh = "";
        $.ajax({
            url: "/admin/HoSo/Edit_HoSo",
            type: "POST",
            data: {
                ID: ID,
                Ho: Ho,
                Ten: Ten,
                NgaySinh: NgaySinh,
                GioiTinh:GioiTinh,
                SoCMND: SoCMND,
                DiaChi: DiaChi,
                HinhAnh:HinhAnh

            },
            dataType: "json",
            success: function (data) {
                if (data.data == true) {
                    location.reload();
                }
            }
        })
        
    }
    this.DoiMatKhau = function () {
        var MatKhauCu = $("#MatKhauCu").val();
        var MatKhauMoi1 = $("#MatKhauMoi1").val();
        var MatKhauMoi2 = $("#MatKhauMoi2").val();

        var Mail_Pass = $("#Mail_Pass").val();
        if(MatKhauCu == "" || MatKhauMoi1 == ""|| MatKhauMoi2 == "")
        {
            $.bootstrapGrowl("Vui nhập đầy đủ các trường !", { type: 'warning' });
           

        } else if (MatKhauMoi1 != MatKhauMoi2){
            $.bootstrapGrowl("Mật khẩu mới của bạn không khấp vui long nhập lại ", { type: 'warning' });
        }
        else {
            $.ajax({
                url: "/admin/HoSo/Doi_MatKhau",
                type: "POST",
                data: {
                    MatKhauCu: MatKhauCu,
                    Mail_Pass: Mail_Pass,
                    MatKhauMoi2: MatKhauMoi2
                   
                },
                dataType: "json",
                success: function (data) {
                    if (data.data == true) {
                        $.bootstrapGrowl("Đổi mật khẩu thành công ", { type: 'success' });
                        $("#MatKhauCu").val("");
                        $("#MatKhauMoi1").val("");
                        $("#MatKhauMoi2").val("");
                    }
                    else {
                        $.bootstrapGrowl("Mật khẩu củ không đúng vui lòng nhập lại !!", { type: 'warning' });
                    }
                }
            })
        }

     
    }
}