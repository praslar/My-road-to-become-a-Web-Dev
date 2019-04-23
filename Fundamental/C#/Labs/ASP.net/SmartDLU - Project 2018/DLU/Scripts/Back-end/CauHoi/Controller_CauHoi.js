function Controller_CauHoi() {
    var id;
    var idEdit;
    var idAddCTL;
    //Modal Create
    this.Modal_CreateCauHoi = function() {
        $("#Modal_Create").modal("show");
        $.ajax({
            url: "/admin/CauHoi/Get_MonHoc",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDMONHOC + `">` + item.TENMONHOC + `</option>`;
                    });
                $("#CauHoi_GetMonHoc_Create").html(html);
            }
        });
        $.ajax({
            url: "/admin/CauHoi/Get_ChuongHoc",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDCHUONGHOC + `">` + item.TENCHUONGHOC + `</option>`;
                    });
                $("#CauHoi_GetChuong_Create").html(html);
            }
        });
        $.ajax({
            url: "/admin/CauHoi/Get_LoaiCauHoi",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDLOAICAUHOI + `">` + item.TENLOAICAUHOI + `</option>`;
                    });
                $("#CauHoi_GetLoaiCauHoi_Create").html(html);
            }
        });
    };
    //Create function
    this.Create_CauHoi = function() {

        var idChuongHoc = $("#CauHoi_GetChuong_Create").val();
        var idLoaiCauHoi = $("#CauHoi_GetLoaiCauHoi_Create").val();
        var noiDungCauHoi = CKEDITOR.instances["CauHoi_NoiDung_Create"].getData();
        var giaiThich = $("#CauHoi_GiaiThich_Create").val();
        var doKho = $("#CauHoi_GetDoKho_Create").val();
        var idMonHoc = $("#CauHoi_GetMonHoc_Create").val();
        if (noiDungCauHoi === "" || doKho === "" || idLoaiCauHoi === "" || doKho === "") {
            $.bootstrapGrowl("Nội dung câu hỏi và độ khó không được để trống !", { type: 'warning' });
        } else {
            $.ajax({
                url: "/admin/CauHoi/Them_CauHoi",
                type: "POST",
                data: {
                    idChuongHoc: idChuongHoc,
                    idLoaiCauHoi: idLoaiCauHoi,
                    noiDung: noiDungCauHoi,
                    giaiThich: giaiThich,
                    DoKho: doKho,
                    IDMonHoc: idMonHoc
                },
                dataType: "json",
                success: function(data) {
                    if (data.data === true) {
                        location.reload();
                    } else if (data.data === "invalidChuong") {
                        $.bootstrapGrowl("Chương học không thuộc môn học đã chọn", { type: 'warning' });
                    } else if (data.data === "invalidDoKho") {
                        $.bootstrapGrowl("Độ khó không thuộc môn học đã chọn", { type: 'warning' });
                    } else
                        $.bootstrapGrowl("Lỗi thêm!", { type: 'warning' });
                }
            });
        }
    };

    //Modal Delete
    this.Modal_DeleteCauHoi = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_CauHoi = function() {
        $.ajax({
            url: "/admin/CauHoi/Xoa_CauHoi",
            type: "POST",
            data: { ID: id },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Lỗi xóa! câu hỏi đang được sử dụng cho các đề thi, không thể xóa dữ liệu!!",
                        { type: 'warning' });
                }
            }
        });
    };

    //Modal Edit
    this.Modal_EditCauHoi = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        //Load dữ liệu cho dropbox môn học
        $.ajax({
            url: "/admin/CauHoi/Get_MonHoc",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDMONHOC + `">` + item.TENMONHOC + `</option>`;
                    });
                $("#CauHoi_GetMonHoc_Edit").html(html);
            }
        });
        //load dữ liệu cho dropbox chương
        $.ajax({
            url: "/admin/CauHoi/Get_ChuongHoc",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDCHUONGHOC + `">` + item.TENCHUONGHOC + `</option>`;
                    });
                $("#CauHoi_GetChuong_Edit").html(html);
            }
        });
        //load dữ liệu cho dropbox hình thức câu hỏi
        $.ajax({
            url: "/admin/CauHoi/Get_LoaiCauHoi",
            type: "POST",
            dataType: "json",
            success: function(data) {
                var html = ``;
                $.each(data.data,
                    function(id, item) {
                        html += `<option value="` + item.IDLOAICAUHOI + `">` + item.TENLOAICAUHOI + `</option>`;
                    });
                $("#CauHoi_GetLoaiCauHoi_Edit").html(html);
            }
        });
        //Tải dữ liệu cữ của câu hỏi vào input giải thích câu hỏi trước khi sửa
        $.ajax({
            url: "/admin/CauHoi/Get_NoiDung_CauHoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                var obj = JSON.parse(data.data);
                $("#CauHoi_GiaiThich_Edit").val(obj.Cauhoi[0].GIAITHICHCAUHOI);
            }
        });
        //Tải dữ liệu cữ của câu hỏi vào input độ khó câu hỏi trước khi sửa
        $.ajax({
            url: "/admin/CauHoi/Get_NoiDung_CauHoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                var obj = JSON.parse(data.data);
                $("#CauHoi_GetDoKho_Edit").val(obj.Cauhoi[0].MUCDOKHO);
            }
        });
        //Tải dữ liệu cữ của câu hỏi vào input nội dung câu hỏi trước khi sửa
        $.ajax({
            url: "/admin/CauHoi/Get_NoiDung_CauHoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                var obj = JSON.parse(data.data);
                CKEDITOR.instances["CauHoi_NoiDung_Edit"].setData(obj.Cauhoi[0].NOIDUNGCAUHOI);
            }
        });
        //không biết tải dữ liệu cũ lên dropbox như thế nào nên bỏ qua phần này
    };
    //Edit function
    this.Edit_CauHoi = function() {
        var idChuongHoc = $("#CauHoi_GetChuong_Edit").val();
        var idLoaiCauHoi = $("#CauHoi_GetLoaiCauHoi_Edit").val();
        var noiDungCauHoi = CKEDITOR.instances["CauHoi_NoiDung_Edit"].getData();
        var giaiThich = $("#CauHoi_GiaiThich_Edit").val();
        var doKho = $("#CauHoi_GetDoKho_Edit").val();
        var id = idEdit;
        var idMonHoc = $("#CauHoi_GetMonHoc_Edit").val();

        if (noiDungCauHoi === "" || doKho === "" || idLoaiCauHoi === "" || doKho === "") {
            $.bootstrapGrowl("Nội dung câu hỏi và độ khó không được để trống !", { type: 'warning' });
        }
        $.ajax({
            url: "/admin/CauHoi/Sua_CauHoi",
            type: "POST",
            data: {
                id: id,
                idChuongHoc: idChuongHoc,
                idLoaiCauHoi: idLoaiCauHoi,
                noiDung: noiDungCauHoi,
                giaiThich: giaiThich,
                DoKho: doKho,
                IDMonHoc: idMonHoc
            },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else if (data.data === "invalidChuong") {
                    $.bootstrapGrowl("Chương học không thuộc môn học đã chọn", { type: 'warning' });
                } else if (data.data === "invalidDoKho") {
                    $.bootstrapGrowl("Độ khó không thuộc môn học đã chọn", { type: 'warning' });
                } else
                    $.bootstrapGrowl("Lỗi thêm!", { type: 'warning' });
            }
        });
    };


    //Modal View danh sách câu trả lời của câu hỏi
    this.Modal_ViewCauTraLoi = function(t) {
        $("#Modal_ViewCauHoi_CuaCauTraLoi").modal("show");
        $.ajax({
            url: "/admin/CauHoi/Get_NoiDung_CauHoi?id=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                var obj = JSON.parse(data.data);
                $(".CauHoi_ID_view").text(obj.Cauhoi[0].IDCAUHOI);
                //lỗi hiển thị
                //$(".CauHoi_NoiDung_View").text(obj.Cauhoi[0].NOIDUNGCAUHOI);
                $("#dsCauTraLoi").children("tr").remove();
                var string = "";
                $.each(obj.CauTraLoi,
                    function(key, value) {
                        string += "<tr>";
                        string += "<td>" + value.IDCAUTL + "</td>";
                        string += "<td>" + value.NOIDUNGCAUTL + "</td>";
                        string += "<td>" + value.DUNGSAI + "</td>";
                        string += "</tr>";
                    });
                $("#dsCauTraLoi").append(string);
            }
        });

    };
    //Modal Thêm câu trả lời của câu hỏi
    this.Modal_AddCauTraLoi = function(t) {
        idAddCTL = t;
        $("#Modal_AddCauTraLoi").modal("show");
        $.ajax({
            url: "/admin/CauTraLoi/Get_CauHoi?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $.each(data.data,
                    function(id, item) {
                        $("#CauTraLoi_MaCauHoi").val(item.IDCAUHOI);
                    });

            }
        });
    };
    //Thêm câu trả lời của câu hỏi
    this.AddCauTraLoi = function() {
        var IDCauHoi = $("#CauTraLoi_MaCauHoi").val();
        var dungsai = $("#CauTraLoi_DungSai_Add").val();
        var index = $("#CauTraLoi_Index_Add").val();
        var NoiDungCauTraLoi = CKEDITOR.instances["CauTraLoi_NoiDung_Add"].getData();

        if (NoiDungCauTraLoi === "" || index === "" || dungsai === "") {
            $.bootstrapGrowl("Thiếu thông tin cần thiết cho câu trả lời !", { type: 'warning' });
        }
        $.ajax({
            url: "/admin/CauTraLoi/Them_CauTraLoi?ID="+IDCauHoi,
            type: "POST",
            data: {
                dungSai: dungsai,
                noiDung: NoiDungCauTraLoi,           
                index: index
            },
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    $.bootstrapGrowl("Thêm thành công", { type: 'success' });
                } else if (data.data === "InvalidNoiDung") {
                    $.bootstrapGrowl("Câu trả lời đã tồn tại!!", { type: 'warning' });
                } else if (data.data === "invalidIndex") {
                    $.bootstrapGrowl("Index câu trả lời đã tồn tại!!", { type: 'warning' });
                } else if (data.data === "invalidDapAnDung") {
                    $.bootstrapGrowl("Đã đủ đáp án đúng cho câu hỏi!!", { type: 'warning' });
                } else
                    $.bootstrapGrowl("Lỗi thêm!", { type: 'warning' });
            }
        });


    };
    //reload page
    this.Reload = function() {
        location.reload();
    };

}
