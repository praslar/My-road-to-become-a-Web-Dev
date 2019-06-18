void XuatMenu()
{
	cout << endl << "=====================HE THONG CHUC NANG===================";
	cout << endl << "0. Thoat khoi chuong trinh.";
	cout << endl << "1. Nhap chuoi";
	cout << endl << "2. Xuat chuoi";
	cout << endl << "3. Noi chuoi sau vao chuoi truoc.";
	cout << endl << "4. Chep chuoi sau vao chuoi truoc.";
	cout << endl << "==========================================================";
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
void XuLyMenu(int menu,String a,String b)
{
	switch (menu)
	{
	case 0:
		exit(1);
		break;
	case 1:
		gets_s(a, MAX);
		gets_s_NhapChuoi(a, 'a');
		cout  << "Chuoi a vua nhap: ";
		XuatChuoi(a);
		cout << endl << "=====================================";
		gets_s_NhapChuoi(b, 'b');
		cout << "Chuoi b vua nhap: ";
		XuatChuoi(b);
		_getch();
		break;
	case 2:
		cout  << "Chuoi a vua nhap: ";
		XuatChuoi(a);
		cout << endl << "=====================================";
		cout << endl << "Chuoi b vua nhap: ";
		XuatChuoi(b);
		_getch();
		break;
	case 3:
		cout << endl << "Chuoi a: "; XuatChuoi(a);
		cout << endl << "Chuoi b: "; XuatChuoi(b);
		Noi_ChuoiSau_VaoSau_ChuoiTruoc(a, b);
		cout << endl << "===============================";
		cout << endl << "Chuoi sau khi noi: ";
		XuatChuoi(a);
		_getch();
		break;
	case 4:
		cout << "\nChep chuoi sau qua chuoi truoc";
		cout << "\nChuoi sau : b = ";
		XuatChuoi(b);
		Chep_ChuoiSau_Qua_ChuoiTruoc(a, b);
		cout << "\nChuoi truoc a,do b chep qua : a = ";
		XuatChuoi(a);
		_getch();
		break;
	case 5:

	default:
		break;
	}
}