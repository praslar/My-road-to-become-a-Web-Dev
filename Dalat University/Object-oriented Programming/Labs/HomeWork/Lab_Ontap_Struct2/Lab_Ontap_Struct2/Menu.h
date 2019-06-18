void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "                    He Thong Chuc Nang";
	cout << endl << "0. Thoat khoi chuong trinh.";
	cout << endl << "1. Xuat danh sach sinh vien. ";
	cout << endl << "2. Xuat bang diem sinh vien.";
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
void XuLyMenu(int menu,SinhVien a[MAX],int &n)
{
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << setiosflags(ios::right)
			<< endl << setw(200) << "Microsoft Visual Studio" 
			<< endl << setw(200) << "Pham Xuan Thang" 
			<< endl << setw(200) << "CTK39B" 
			<< endl << setw(200) << "1510251" 
			<< endl << setw(200) << "C++ learner" 
			<< endl << setw(200) << "Local Windows Debug" 
			<< endl << setw(200) << "Da Lat" 
			<< endl << setw(200) << "7/10/2017" << setw(30);
		cout << setiosflags(ios::left)
			<< endl << "Thank you for your cooperation!"
			<< endl << "Hope you like my project"
			<< endl << "See you next time"
			<< endl << "BYE!"
			<< endl << "                                       THE END                             "
			<< endl << setw(30) << "                            -------Press any key to exit--------" << setw(30);
		_getch();
		break;
	case 1:
		Tao_DS_SV(a, n);
		Xuat_DS_Lop(a, n);
		cout << endl << "So sinh vien co trong danh: " << n;
		_getch();
		break;
	case 2:
		Tao_BangDiem_SV(b, n);
		TinhDiemTongKet(b, n);
		Xuat_Diem_Lop(b, n);
		cout << endl << "So sinh vien co trong danh: " << n;
		_getch();
		break;
	default:
		break;
	}
}