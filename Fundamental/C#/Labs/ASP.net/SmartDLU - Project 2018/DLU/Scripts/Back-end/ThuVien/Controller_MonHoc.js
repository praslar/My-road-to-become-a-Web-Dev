function Controller_MonHoc() {
    var id;
    var idEdit;
    //Modal Create
    this.Modal_CreateMonHoc = function() {
        $("#Modal_Create").modal("show");
        $.ajax({
            url: "/admin/MonHoc/Get_SoLuongDoKho",
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
    this.Create_MonHoc = function() {
        var tenMon = $("#TenMonHoc").val();
        var moTa = $("#MoTaMonHoc").val();
        var idSoLuongDoKho = $("#MucDoKho").val();

        if (tenMon === "" || idSoLuongDoKho === "") {
            $.bootstrapGrowl("Tên môn học và số lượng mức độ khó không được để trống !", { type: 'warning' });
        } else {
            $.ajax({
                url: "/admin/MonHoc/Them_MonHoc",
                type: "POST",
                data: {
                    tenMon: tenMon,
                    moTa: moTa,
                    IDSoLuongDoKho: idSoLuongDoKho
                },
                dataType: "json",
                success: function(data) {
                    if (data.data === true) {
                        $.bootstrapGrowl("Thêm thành công!", { type: 'success' });
                        location.reload();

                    } else {
                        $.bootstrapGrowl("Tên môn học đã tồn tại!", { type: 'warning' });
                    }
                }
            });
        }
    };


    //Modal Delete
    this.Modal_DeleteMonHoc = function(t) {
        id = t;
        $("#Modal_Delete").modal("show");
    };
    //Delete function
    this.Delete_MonHoc = function() {
        $.ajax({
            url: "/admin/MonHoc/Xoa_MonHoc?ID=" + id,
            type: "POST",
            dataType: "json",
            success: function(data) {
                if (data.data === true) {
                    location.reload();
                } else {
                    $.bootstrapGrowl("Còn tồn tại câu hỏi thuộc môn học này, không thể xóa!", { type: 'warning' });
                }


            }
        });
    };


    //Modal Edit
    this.Modal_EditMonHoc = function(t) {
        idEdit = t;
        $("#Modal_Edit").modal("show");
        $.ajax({
            url: "/admin/MonHoc/Get_SoLuongDoKho",
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
        $.ajax({
            url: "/admin/MonHoc/Get_MonHoc?ID=" + t,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $.each(data.data,
                    function(id, item) {
                        $("#TenMonHoc_Edit").val(item.TENMONHOC);
                        $("#MoTaMonHoc_Edit").val(item.MOTAMONHOC);
                    });

            }
        });
    };
    //Edit function
    this.Edit_MonHoc = function() {
        var tenMon = $("#TenMonHoc_Edit").val();
        var moTa = $("#MoTaMonHoc_Edit").val();
        var idSoLuongDoKho = $("#MucDoKho_Edit").val();
        var id = idEdit;

        if (tenMon === "" || idSoLuongDoKho === "") {
            $.bootstrapGrowl("Tên môn học và số lượng mức độ khó không được để trống !", { type: 'warning' });
        }

        $.ajax({
            url: "/admin/MonHoc/Sua_MonHoc",
            type: "POST",
            data: {
                id: id,
                tenMon: tenMon,
                moTa: moTa,
                IDSoLuongDoKho: idSoLuongDoKho
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


    // xem ch

    this.Modal_xemCH = function(idmonhoc) {
        $("#Modal_view").modal("show");
        $.ajax({
            url: "/admin/MonHoc/Get_MonHoc?ID=" + idmonhoc,
            type: "POST",
            dataType: "json",
            success: function(data) {
                if (data === false) {
                    $.bootstrapGrowl("Không tồn tại chương của môn học!", { type: 'warning' });
                } else {
                    $.each(data.data,
                        function(id, item) {
                            $("#monhoc_xemChuong").text(item.TENMONHOC);
                        });
                }
            }
        });

        $.ajax({
            url: "/admin/MonHoc/Get_chuong?ID=" + idmonhoc,
            type: "POST",
            dataType: "json",
            success: function(data) {
                $("#dsChuong").children("tr").remove();
                var string = "";
                console.log(data);
                $.each(data.data,
                    function(id, item) {
                        string += "<tr>";
                        string += "<td>" + item.IDCHUONGHOC + "</td>";
                        string += "<td>" + item.TENCHUONGHOC + "</td>";
                        string += "<td>" + item.MOTACHUONGHOC + "</td>";
                        string += "</tr>";
                    });
                $("#dsChuong").append(string);
            }
        });
    };
}

