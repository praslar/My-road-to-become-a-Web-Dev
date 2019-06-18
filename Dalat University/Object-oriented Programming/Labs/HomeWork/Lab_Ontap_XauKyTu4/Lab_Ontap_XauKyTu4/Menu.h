void XuatMenu()
{
	cout << endl << "================HE THONG CHUC NANG=============";
	cout << endl << "0.Thoat khoi chuong trinh.";
	cout << endl << "1. Nhap chuoi.";
	cout << endl << "2. Xem chuoi.";
	cout << endl << "3. Nan ten.";
	cout << endl << "4. Tinh chieu dai chuoi";
	cout << endl << "5. Chen kt vao dau chuoi.";
	cout << endl << "6. Chen kt vao cuoi chuoi.";
	cout << endl << "7. Chen kt vao vi tri x trong chuoi.";
	cout << endl << "8. Xoa ky tu tai vi tri x trong chuoi.";
	cout << endl << "9. Cat ky tu dau chuoi chen vao cuoi chuoi.";
	cout << endl << "10. Cat ky tu cuoi chuoi chen vao dau chuoi.";
	cout << endl << "11. Xoa tat ca cac ky tu x cho truoc khoi chuoi.";
	cout << endl << "12. Thay the tat cac ky ty x trong chuoi thanh ky tu y.";
	cout << endl << "===============================================";
}
int ChonMenu(int soMenu)
{
	int stt;
	for (;;)
	{
		system("CLS");
		XuatMenu();
		cout << endl << "Chon menu: ";
		cin >> stt;
		if (0 <= stt && stt <= soMenu)
			break;
	}
	return stt;
}
void XuLyMenu(int menu,String a)
{
	int kq;
	char x,y;
	int l, vt;
	switch (menu)
	{
	case 0: 
		cout << endl << "Thank you for your cooperation!" << endl << "=========== Press any key to exit ===========";
		_getch();
		break;
	case 1:
		gets_s(a,MAX);
		gets_s_NhapChuoi(a, 'a');
		cout << endl << "Chuoi vua nhap: ";
		XuatChuoi(a);
		_getch();
		break;
	case 2:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		_getch();
		break;
	case 3:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		NanTen(a);
		cout << endl << "Chuoi sau khi nan: ";
		cout << a;
		_getch();
		break;
	case 4:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		kq = strlen_ChieuDai_Chuoi(a);
		cout << endl << "Chieu dai chuoi (strlen)= " << kq;
		kq = TinhChieuDaiChuoi(a);
		cout << endl << "Chieu dai chuoi (while)= " << kq;
		_getch();
		break;
	case 5:
		char x;
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		cout << endl << "Nhap ki tu muon chen vao dau chuoi: ";
		cin >> x;
		ChenDau_KT(a, x);
		cout << endl << "Chuoi sau khi chen: ";
		XuatChuoi(a);
		_getch();
		break;
	case 6:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		cout << endl << "Nhap ki tu muon chen vao cuoi chuoi: ";
		cin >> x;
		ChenCuoi_KT(a, x);
		cout << endl << "Chuoi sau khi chen: ";
		XuatChuoi(a);
		_getch();
		break;
	case 7:
		l = TinhChieuDaiChuoi(a);
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		cout << endl << "Nhap vi tri can chen ki tu trong chuoi (0 - > " << l << "): ";
		cin >> vt;
		kq = ChenKT_VT(a, x, vt);
		if (kq)
		{
			cout << endl << "Chuoi sau khi chen: ";
			XuatChuoi(a);
		}
		else
			cout << endl << "Loi xac dinh vi tri!";
		_getch();
		break;
	case 8:
		l = TinhChieuDaiChuoi(a);
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		cout << endl << "Nhap vi tri can xoa ki tu trong chuoi (0 - > " << l << "): ";
		cin >> vt;
		kq = XoaKT_VT(a,vt);
		if (kq)
		{
			cout << endl << "Chuoi sau khi xoa: ";
			XuatChuoi(a);
		}
		else
			cout << endl << "Loi xac dinh vi tri!";
		_getch();
		break;
	case 9:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		CatDauChenCuoi(a);
		cout << endl << "Chuoi sau khi thuc hien chuc nang: ";
		XuatChuoi(a);
		_getch();
		break;
	case 10:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		CatCuoiChenDau(a);
		cout << endl << "Chuoi sau khi thuc hien chuc nang: ";
		XuatChuoi(a);
		_getch();
		break;
	case 11:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		cout << endl << "Nhap ki tu can xoa trong mang: ";
		cin >> x;
		Xoa_x(a, x);
		cout << endl << "Chuoi sau khi thuc hien chuc nang: ";
		XuatChuoi(a);	
		_getch();
		break;
	case 12:
		cout << endl << "Chuoi hien hanh: ";
		XuatChuoi(a);
		cout << endl << "Nhap ki tu can thay the trong mang: ";
		cin >> x;
		cout << endl << "Nhap ki tu de thay de cho ki tu cu: ";
		cin >> y;
		Thay_x_Bang_y(a, x, y);
		cout << endl << "Chuoi sau khi thuc hien chuc nang: ";
		XuatChuoi(a);
		_getch();
		break;
	default:
		break;
	}
}
