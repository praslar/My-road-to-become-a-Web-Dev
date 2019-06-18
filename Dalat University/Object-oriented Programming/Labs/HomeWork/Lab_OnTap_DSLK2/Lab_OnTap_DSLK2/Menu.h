void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "           He Thong Chuc Nang              ";
	cout << endl << "0. Thoat khoi chuong trinh.";
	cout << endl << "1. Nhap tu file.";
	cout << endl << "2. Xuat danh sach nhan vien.";
	cout << endl << "1. Tach danh sach nhan vien theo luong.";
	cout << endl << "2. Tach dach sach nhan vien theo thu tu.";
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
void XuLyMenu(int menu,NhanVien x,LISTNV &list)
{
	char filename[10];
	switch (menu)
	{
	case 0:
		cout << endl << "End of the project!";
		cout << endl << "Hope you like it.";
		cout << endl << "Thank you.";
		cout << endl << "BYE!";
		cout << endl << "---------Press any key to exit------------";
		_getch();
		break;
	case 1:
		cout << endl << "Nhap ten file do doc: ";
		cin >> filename;
		File_List_NV(filename, list);
		Xuat_DSNV(list,n);
		_getch();
		break;
	default:
		break;
	}
}