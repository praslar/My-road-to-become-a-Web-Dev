void XuatMenu()
{
	cout << endl << "         <He Thong Chuc Nang>";
	cout << endl << "0.Thoat khoi chuong trinh!";
	cout << endl << "1.Doc va xuat danh sach nhan vien";
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
	char filename[20];
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << endl << "Exit!";
		_getch();
		break;
	case 1:

	default:
		break;
	}
}
