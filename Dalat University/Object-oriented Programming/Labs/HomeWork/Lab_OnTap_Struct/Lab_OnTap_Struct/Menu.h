void XuatMenu()
{
	cout << endl << "=============He Thong Chuc Nang=============";
	cout << "\n0. Thoat khoi chuong trinh";
	cout << "\n1. Nhap danh sach nhan vien";
	cout << "\n2. xem danh sach nhan vien";
	cout << "\n3. Them mot nhan vien vao cuoi danh sach";
	cout << "\n4. Xoa mot nhan vien theo ma nhan vien";
	cout << "\n5. Sua thong tin nhan vien theo ma nhan vien";
	cout << "\n6. Tim nhan vien theo ma so";
	cout << "\n7. Tim nhan vien theo ten";
	cout << "\n8. Sap danh sach nhan vien tang dan theo ma nhan vien";
	cout << "\n9. Sap danh sach nhan vien tang dan theo ten - ho - luong";
	cout << "\n10. Tinh tong luong thang";
	cout << "\n11. Liet ke cac nhan vien co luong >= x (nhap tu ban phim)";
	cout << "\n12. Liet ke cac nhan vien co nam sinh trong khoang [h,t]";
	cout << endl << "13. Tao danh sach nhan vien.";
	cout << endl << "=============================================";
}
int ChonMenu(int soMenu)
{
	int stt;
	for (;;)
	{
		system("CLS");
		Xuat_DSNV(a, n);
		XuatMenu();
		cout << endl << "Chon chuc nang can thuc hien: ";
		cin >> stt;
		if (0 <= stt && stt <= soMenu)
			break;
	}
	return stt;
}
void XuLyMenu(int menu,NhanVien a[MAX],int &n)
{
	char maNV[8];
	char tenNV[8];
	int kq;
	double x;
	unsigned int h, t;
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << endl << "    Thanks for your cooperation!";
		cout << endl << "-------Press any key to exit-------";
		_getch();
		break;
	case 1:
		Nhap_DSNV(a, n);
		system("CLS");
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 2:
		system("CLS");
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 3:
		cout << endl << "Nhap thong tin nhan vien can them vao cuoi danh sach:\n ";
		Nhap_1NV(p);
		system("CLS");
		Them_NV_Cuoi(a, n, p);
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 4:
		cout << endl << "Nhap ma nhan vien can xoa khoi danh sach: ";
		cin >> maNV;
		system("CLS");
		Xoa_NV_MaNV(a, n, maNV);
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 5:
		cout << endl << "Nhap ma nhan vien can sua trong danh sach: ";
		cin >> maNV;
		system("CLS");
		Sua_NV_MaNV(a, n, maNV);
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 6:
		cout << endl << "Nhap ma nhan vien can sua trong danh sach: ";
		cin >> maNV;
		system("CLS");
		kq = Tim_NV_MaNV(a, n, maNV);
		if (kq)
		{
			cout << endl << "::Result:: ";
			TieuDe();
			Xuat_1NV(a[kq]);
		}
		else
			cout << endl << "Loi xac dinh ma NV: " << maNV;
		_getch();
		break;
	case 7:
		cout << endl << "Nhap ten nhan vien can tim trong danh sach: ";
		cin >> tenNV;
		system("CLS");
		Tim_NV_Ten(a, n, tenNV);
		_getch();
		break;
	case 8:
		system("CLS");
		cout << endl << "Danh sach nhan vien theo thu tu ma NV tang.";
		Sap_Tang_MaNV(a, n);
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 9:
		system("CLS");
		cout << endl << "Danh sach nhan vien tang dang theo ten_ho_luong.";
		Sap_Tang_Ho_TenLot_Ten_Luong(a, n);
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	case 10:
		kq = Tong_Luong_NV(a, n);
		cout << endl << "Tong so luong cua nhan vien: Sum = " << kq;
		_getch();
		break;
	case 11:
		cout << endl << "Nhap muc luong can tim: ";
		cin >> x;
		system("CLS");
		Tim_NV_Luong(a, n, x);
		_getch();
		break;
	case 12:
		cout << endl << "Nhap nam sinh can tim: ";
		cout << endl << "Tu nam: "; cin >> h;
		cout << endl << "Den nam: "; cin >> t;
		system("CLS");
		Tim_NV_NamSinh(a, n, h, t);
		_getch();
		break;
	case 13:
		system("CLS");
		TaoDanhSachNhanVien(a,n);
		cout << endl << "Danh sach nhan vien hien hanh: \n";
		Xuat_DSNV(a, n);
		cout << endl << "So luong nhan vien hien tai: " << n;
		_getch();
		break;
	default:
		break;
	}
}