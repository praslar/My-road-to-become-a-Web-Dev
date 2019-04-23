function ConTroller_LichThi() {
	var id = -1;


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

	function Load_DanhSachLichThi() {
		waitingDialog.show();
		$.ajax({
			url: "/admin/LichThi/Get_ALL",
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
                                <td> `+ row.IDLICHTHI + ` </td>
                                <td> `+ row.IDBODE + ` </td>
								<td> `+ Get_TenDotThi(row.IDDOTTHI) + ` </td>
								<td> `+ Get_TenMonHoc(row.IDHOCKI) + ` </td>
								<td> `+ row.NGAYTHI + ` </td>
								<td> `+ row.GIOTHI + ` </td>
								<td> `+ row.PHONGTHI + ` </td>
                                <td class ="text-center">
                                    <a href="#" class ="btn btn-success btn-xs btn-flat" onclick= "" >Xem</a>
                                </td>
                               </tr>
                        `;

				});
				var table = $('#example_LichThi').DataTable();
				table.destroy();
				$("#data_LichThi").html(HTML);

				$('#example_LichThi').DataTable({
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
	Load_DanhSachLichThi();

	this.Modal_Edit_LichThi = function (t) {
		$("#Modal_Edit_LichThi").modal("show");
		$.ajax({
			url: "/admin/LichThi/Get_LichThi",
			type: "POST",
			data: { IDLICHTHI: t },
			dataType: "json",
			success: function (data) {
				$.each(data.data, function (IDLICHTHI, item) {
					$("#txtIdBoDe").val(item.IDBODE);
					$("#txtIdDotThi").val(item.IDDOTTHI);
					$("#txtIdHocKi").val(item.IDHOCKI);
					$("#txtIdGiaoVien").val(item.IDGIAOVIEN);
					$("#txtIdNgayThi").val(item.NGAYTHI);
					$("#txtIdGioThi").val(item.GIOTHI);
					$("#txtIdPhongThi").val(item.PHONGTHI);
					$("#txtIdLichThi").val(item.IDLICHTHI);
				});
			}
		})
	}
	this.Edit_LichThi = function () {
		var IDBODE = $("#txtIdBoDe").val();
		var IDDOTTHI = $("#txtIdDotThi").val();
		var IDHOCKI = $("#txtIdHocKi").val();
		var IDGIAOVIEN = $("#txtIdGiaoVien").val();
		var NGAYTHI = $("#txtIdNgayThi").val();
		var GIOTHI = $("#txtIdGioThi").val();
		var PHONGTHI = $("#txtIdPhongThi").val();
		var id = $("#txtIdLichThi").val();
		$.ajax({
			url: "/admin/LichThi/Edit_LichThi",
			type: "POST",
			data: { id: id, IDBODE: IDBODE, IDDOTTHI: IDDOTTHI, IDHOCKI: IDHOCKI, IDGIAOVIEN: IDGIAOVIEN, NGAYTHI: NGAYTHI, GIOTHI: GIOTHI, PHONGTHI: PHONGTHI},
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					location.reload();
				}
			}
		})
	}
	this.Modal_Delete_Nhom = function (t) {
		id = t;
		$("#Modal_Delete_Nhom").modal("show");
	}
	this.Delete_Nhom = function () {
		$.ajax({
			url: "/admin/Nhom/Delete_Nhom",
			type: "POST",
			data: { id: id },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					location.reload();
				}
			}
		})
	}
	this.Modal_Create_Nhom = function () {
		$("#Modal_Create_Nhom").modal("show");
	}
	this.Create_Nhom = function () {
		var tenNhom = $("#txtTenNhom_create").val();
		var moTa = $("#txtMoTa_create").val();
		var tenLop = $("#txtLop_create").val();
		$.ajax({
			url: "/admin/Nhom/Create_Nhom",
			type: "POST",
			data: { tenNhom: tenNhom, moTa: moTa, tenLop: tenLop },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					location.reload();
				}
			}
		})
	}
}