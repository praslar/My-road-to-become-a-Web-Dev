void XuatMenu()
{
	cout << endl << "==================He Thong Chuc Nang==================";
	cout << endl << "0. Thoat khoi chuong trinh.";
	cout << endl << "1. Doc du lieu tu file.";
	cout << endl << "2. Xem danh sach.";
	cout << endl << "=======================================================";
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
void XuLyMenu(int menu)
{
	switch (menu)
	{
	case 0:
		cout << endl << "Thank you for your cooperation!\n";
		cout << endl << "----Press any key to exit----";
		_getch();
		break;
	case 1:
		char filename[80];
		cout << "Nhap ten file: ";
		cin >> filename;
		n = doc_file(filename, ds);
		_getch();
		break;
	case 2:
		cout << endl << "Danh sach hien hanh:\n";
		Xuat_DS(ds, n);
		_getch();
		break;
	default:
		break;
	}
}