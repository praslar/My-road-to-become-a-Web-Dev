void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "           <HE THONG CHUC NANG>";
	cout << endl << "0. Thoat khoi chuong trinh.";
	cout << endl << "1. Xuat danh sach nhan vien.";
	cout << endl << "2. Phan loai nhan vien theo muc luong.";
	cout << endl << "3. Tach danh sach nhan vien luan phien.";
	cout << endl << "4. Dao nguoc danh sach.";
	KeNgangDoi();
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
void XuLyMenu(int menu,int &n)
{
	double a;
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << endl << "=============================Press any key to exit=======================";
		_getch();
		break;
	case 1:
		system("CLS");
		Read_File_NV("Nhanvien.txt", list, n);
		Xuat_DS(list);
		cout << endl << "So nhan vien trong danh sach: " << n;
		_getch();
		break;
	case 2:
		system("CLS");
		cout << endl << "Phan loai nhan vien: ";
		cout << endl << "Nhap muc luong muon phan loai: x= ";
		cin >> a;
		Tach_Luong(list, a);
		_getch();
		break;
	case 3:
		system("CLS");
		Tach_LuanPhien(list);
		_getch();
		break;
	case 4:
		system("CLS");
		cout << endl << "Danh sach dao nguoc: ";
		DaoNguoc(list);
		_getch();
		break;
	default:
		break;
	}
}