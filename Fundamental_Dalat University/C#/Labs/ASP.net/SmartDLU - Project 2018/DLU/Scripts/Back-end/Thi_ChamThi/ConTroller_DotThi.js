function ConTroller_DotThi() {
	var ID_Delete = 0;
	function Load_DanhSachDotThi() {
		waitingDialog.show();
		$.ajax({
			url: "/admin/DotThi/Get_DotThi_ALL",
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
                                <td> `+ row.TENDOTTHI + ` </td>
                                <td> `+ row.MOTA + ` </td>
                                <td class ="text-center">
                                    <a href="#" class ="btn btn-success btn-xs btn-flat" onclick= "DotThi.Modal_Create_Edit_DotThi(`+ row.IDDOTTHI + `,'Update')" >Sửa</a>
                                     <a class ="btn btn-danger btn-xs btn-flat" onclick= "DotThi.Modal_Delete_DotThi(`+ row.IDDOTTHI + `)" >Xóa</a>
                                </td>
                               </tr>
                        `;

				});
				var table = $('#example_DotThi').DataTable();
				table.destroy();
				$("#data_DotThi").html(HTML);

				$('#example_DotThi').DataTable({
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
	Load_DanhSachDotThi();
	this.Modal_Delete_DotThi = function (IDDOTTHI) {
		ID_Delete = IDDOTTHI;
		$("#Modal_Delete_DotThi").modal("show");

	}
	this.Delete_DotThi = function () {
		$.ajax({
			url: "/admin/DotThi/Delete_DotThi",
			type: "POST",
			data: { ID_Delete: ID_Delete },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					Load_DanhSachDotThi();
					$.bootstrapGrowl("Xóa thành công ", { type: 'success' });
					$("#Modal_Delete_DotThi").modal("hide");
				}
			}
		})
	}
	this.Modal_Create_Edit_DotThi = function (id, type) {
		if (type == "Add") {
			$(".btn_Add").show()
			$(".btn_Update").hide();
			$(".txt_title").text("Thêm đọt thi mới");
			$("#txtID").val("");
			$("#txtTenDotThi").val("");
			$("#txtMoTaDotThi").val("");
			$("#Modal_Create_Edit_DotThi").modal("show");
		} else {
			$(".btn_Add").hide()
			$(".btn_Update").show();
			$(".txt_title").text("Chỉnh sửa đợt thi");
			$.ajax({
				url: "/admin/DotThi/Get_DotThi_ByID",
				type: "POST",
				data: { ID: id },
				dataType: "json",
				success: function (data) {
					$.each(data.data, function (ID, item) {
						$("#txtID").val(item.ID);
						$("#txtTenDotThi").val(item.TENDOTTHI);
						$("#txtMoTaDotThi").val(item.MOTA);

					});
					$("#Modal_Create_Edit_DotThi").modal("show");
				}
			})
		}

	}
	this.Create_DotThi = function () {
		var TenDotThi = $("#txtTenDotThi").val();
		var MoTa = $("#txtMoTaDotThi").val();
		$.ajax({
			url: "/admin/DotThi/Create_DotThi",
			type: "POST",
			data: { TENDOTTHI: TenDotThi, MOTA: MoTa },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					Load_DanhSachDotThi();
					$.bootstrapGrowl("Thêm thành công ", { type: 'success' });
					$("#Modal_Create_Edit_Lop").modal("hide");
				}
			}
		})
	}
	this.Edit_DotThi = function () {
		var ID = $("#txtID").val();
		var TenDotThi = $("#txtTenDotThi").val();
		var MoTa = $("#txtMoTaDotThi").val();
		$.ajax({
			url: "/admin/DotThi/Edit_DotThi",
			type: "POST",
			data: { ID: ID, TENDOTTHI: TenLop, MOTA: MoTaLop },
			dataType: "json",
			success: function (data) {
				if (data.data == true) {
					Load_DanhSachDotThi();
					$.bootstrapGrowl("Sửa thành công ", { type: 'success' });
					$("#Modal_Create_Edit_Lop").modal("hide");
				}
			}
		})
	}
}