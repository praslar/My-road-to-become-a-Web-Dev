function ConTroller_HocKi() {
	var ID_Delete = 0;
	function Load_DanhSachHocKi() {
		waitingDialog.show();
		$.ajax({
			url: "/admin/HocKi/Get_HocKi_ALL",
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
                                <td> `+ row.TENHOCKI + ` </td>
                                <td> `+ row.MOTA + ` </td>
                                <td class ="text-center">
                                    <a href="#" class ="btn btn-success btn-xs btn-flat" onclick= "HocKi.Modal_Create_Edit_HocKi(`+ row.IDHOCKI + `,'Update')" >Sửa</a>
                                     <a class ="btn btn-danger btn-xs btn-flat" onclick= "HocKi.Modal_Delete_HocKi(`+ row.IDHOCKI + `)" >Xóa</a>
                                </td>
                               </tr>
                        `;

				});
				var table = $('#example_HocKi').DataTable();
				table.destroy();
				$("#data_HocKi").html(HTML);

				$('#example_HocKi').DataTable({
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
	Load_DanhSachHocKi();
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