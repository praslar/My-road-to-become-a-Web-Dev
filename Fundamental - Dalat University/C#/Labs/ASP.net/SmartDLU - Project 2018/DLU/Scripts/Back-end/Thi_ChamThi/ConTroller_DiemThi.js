function ConTroller_DiemThi() {
	var ID_Delete = 0;

	function Get_TenMonHoc(ID) {
		var TenMonHoc = ``;
		$.ajax({
			url: "/admin/DiemThi/Get_TenMonHoc",
			type: "POST",
			data: { ID: ID },
			dataType: "json",
			async: false,
			success: function (data) {
				TenMonHoc = data.data;

			}
		});
		return TenMonHoc;
	}

	function Get_TenHocKi(ID) {
		var TenHocKi = ``;
		$.ajax({
			url: "/admin/DiemThi/Get_TenHocKi",
			type: "POST",
			data: { ID: ID },
			dataType: "json",
			async: false,
			success: function (data) {
				TenHocKi = data.data;

			}
		});
		return TenHocKi;
	}

	function Get_TenDotThi(ID) {
		var TenDotThi = ``;
		$.ajax({
			url: "/admin/DiemThi/Get_TenDotThi",
			type: "POST",
			data: { ID: ID },
			dataType: "json",
			async: false,
			success: function (data) {
				TenDotThi = data.data;

			}
		});
		return TenDotThi;
	}

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

	function Load_DanhSachDiemThi() {
		waitingDialog.show();
		$.ajax({
			url: "/admin/DiemThi/Get_DiemThi_ALL",
			type: "POST",
			dataType: "json",
			success: function (data) {
				var HTML = ``;
				var i = 0;
				$.each(data.data, function (Id, row) {
					i++;
					HTML += `
                            <tr>
                                <th class ="text-center"> `+ i + ` </th>
                                <td> `+ Get_HoTen(row.ID) + ` </td>
                                <td> `+ Get_TenHocKi(row.IDHOCKI) + ` </td>
								<td> `+ Get_TenDotThi(row.IDDOTTHI) + ` </td>
								<td> `+ Get_TenMonHoc(row.IDMONHOC) + ` </td>
								<td> `+ row.CANHCAO + ` </td>
								<td> `+ row.DINHCHI  + ` </td>
								<td> `+ row.TONGDIEM  + ` </td>
                                <td class ="text-center">
                                    <a href="#" class ="btn btn-success btn-xs btn-flat" onclick= "" >Xem</a>
                                </td>
                               </tr>
                        `;

				});
				var table = $('#example_DiemThi').DataTable();
				table.destroy();
				$("#data_DiemThi").html(HTML);

				$('#example_DiemThi').DataTable({
					'paging': false,
					'lengthChange': false,
					'searching': true,
					'ordering': true,
					'info': false,
					"scrollY": 300,
				});
				waitingDialog.hide()
			}
		});
	}
	Load_DanhSachDiemThi();
	this.Modal_Delete_HocKi = function (ID) {
		ID_Delete = ID;
		$("#Modal_Delete_HocKi").modal("show");

	}
	this.Delete_HocKi = function () {
		$.ajax({
			url: "/admin/HocKi/Delete_HocKi",
			type: "POST",
			data: { ID_Delete: ID_Delete },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					Load_DanhSachHocKi();
					$.bootstrapGrowl("Xóa thành công ", { type: 'success' });
					$("#Modal_Delete_HocKi").modal("hide");
				}
			}
		})
	}
	this.Modal_Create_Edit_HocKi = function (id, type) {
		if (type == "Add") {
			$(".btn_Add").show()
			$(".btn_Update").hide();
			$(".txt_title").text("Thêm đọt thi mới");
			$("#txtID").val("");
			$("#txtTen").val("");
			$("#txtMoTa").val("");
			$("#Modal_Create_Edit_HocKi").modal("show");
		} else {
			$(".btn_Add").hide()
			$(".btn_Update").show();
			$(".txt_title").text("Chỉnh sửa đợt thi");
			$.ajax({
				url: "/admin/HocKi/Get_HocKi_ByID",
				type: "POST",
				data: { ID: id },
				dataType: "json",
				success: function (data) {
					$.each(data.data, function (ID, item) {
						$("#txtID").val(item.ID);
						$("#txtTen").val(item.TENHOCKI);
						$("#txtMoTa").val(item.MOTA);

					});
					$("#Modal_Create_Edit_HocKi").modal("show");
				}
			})
		}

	}
	this.Create_HocKi = function () {
		var Ten = $("#txtTen").val();
		var MoTa = $("#txtMoTa").val();
		$.ajax({
			url: "/admin/HocKi/Create_HocKi",
			type: "POST",
			data: { TENHOCKI: Ten, MOTA: MoTa },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					Load_DanhSachHocKi();
					$.bootstrapGrowl("Thêm thành công ", { type: 'success' });
					$("#Modal_Create_Edit_HocKi").modal("hide");
				}
			}
		})
	}
	this.Edit_HocKi = function () {
		var ID = $("#txtID").val();
		var Ten = $("#txtTen").val();
		var MoTa = $("#txtMoTa").val();
		$.ajax({
			url: "/admin/HocKi/Edit_HocKi",
			type: "POST",
			data: { ID: ID, TENDOTTHI: TenLop, MOTA: MoTaLop },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					Load_DanhSachHocKi();
					$.bootstrapGrowl("Sửa thành công ", { type: 'success' });
					$("#Modal_Create_Edit_HocKi").modal("hide");
				}
			}
		})
	}
}