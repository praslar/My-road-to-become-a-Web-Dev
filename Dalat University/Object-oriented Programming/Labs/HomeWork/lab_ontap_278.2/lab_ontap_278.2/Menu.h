void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "                          <HE THONG CHUC NANG>";
	cout << endl << "0.Thoat khoi chuong trinh.";
	cout << endl << "1.Xuat danh sach nhan vien.";
	cout << endl << "2.Tim nhan vien theo ma so nhan vien.";
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
	char maNV[10];
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << endl << "================PRESS ANY KEY TO EXIT======================";
		_getch();
		break;
	case 1:
		system("CLS");
		n = Read_File_Array("Nhanvien.txt", danhsach);
		Xuat_DSNV(danhsach,n);
		_getch();
		break;
	case 2:
		system("CLS");
		cout << endl << "Danh sach hien hanh:\n";
		Xuat_DSNV(danhsach, n);
		cout << endl << "Nhap ma nhan vien can tim:\n";
		cin >> maNV;
		Linesearch_All_MaNV(danhsach, n, maNV);
		_getch();
		break;
	default:
		break;
	}
}