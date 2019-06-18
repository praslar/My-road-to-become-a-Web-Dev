void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "                            <HE THONG CHUC NANG>";
	cout << endl << "0. Thoat khoi chuong trinh.";
	cout << endl << "1. Xuat danh sach nhan vien.";
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
void XuLyMenu(int menu)
{
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << endl << "PRESS ANY KEY TO EXIT!!!";
		cout << endl << "Thank you for your cooperation!";
		_getch();
		break;
	case 1:
		system("CLS");
		soluongnhanvien = Read_File_Array("Nhanvien.txt", danhsach);
		Xuat_DSNV(danhsach, soluongnhanvien);
		_getch();
		break;
	default:
		break;
	}
}