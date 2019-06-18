void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "                            <He Thong Chuc Nang>" ;
	cout << endl << "| 0. Thoat khoi chuong trinh.";
	cout << endl << "| 1. Doc File text1.txt";
	cout << endl << "| 2. Ghi File text2.txt";
	cout << endl << "| 3. Doc File_Matrix text3.txt";
	cout << endl << "| 4. Ghi File_Matrix text4.txt";
	cout << endl << "| 5. Doc va Xuat file nhanvien.txt";
	cout << endl << "| 6. Ghi va Xuat file nhanvien2.txt";

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
void XuLyMenu(int menu,String a,Matrix b,int &n)
{
	char filename[20];
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << setiosflags(ios::right);
		cout << setw(50) << endl << "Microsoft Visual Studio" << TAB << "Pham Xuan Thang"
			<< setw(50) << endl << "Local Windows Debugger" << TAB << "CTK39B"
			<< setw(50) << endl << "Server Explorer" << TAB << "1510251"
			<< setw(50) << endl << "Toolboxes" << TAB << "12/7/2017"
			<< setw(50) << endl << "Quick Launch" << TAB << "Da Lat";
		cout << endl << endl << endl;
		cout << endl << "                                      PROJECT MID-TERM-EXAM";
		cout << endl << "Thank you for your cooperation";
		cout << endl << "Next project: Final exam ";
		cout << endl << "Lauch date: **/8/2017" << TAB << "Time: 4:00 PM";
		cout << endl << "Remember:: Always do your best!";
		cout << endl << "                                                  THE END";
		_getch();
		break;
	case 1:
		system("CLS");
		cout << endl << "Nhap ten file de doc: ";
		cin >> filename;
		Read_File_Array(filename, a, n);
		cout << endl << n;
		cout << endl;
		for (int i = 0; i < n; i++)
		{
			cout << a[i] << TAB;
		}
		_getch();
		break;
	case 2:
		system("CLS");
		cout << endl << "Nhap ten file de ghi: ";
		cin >> filename;
		Write_File_Array(filename, a, n);
		_getch();
		break;
	case 3:
		system("CLS");
		cout << endl << "Nhap ten file de ghi: ";
		cin >> filename;
		Read_File_Matrix(filename, b, n);
		cout << endl << "n= " << n;
		cout << endl;
		for (int i = 0; i < n; i++)
		{
			cout << endl;
			for (int j = 0; j < n; j++)
				cout << b[i][j] << TAB;
		}
		_getch();
		break;
	case 4:
		system("CLS");
		cout << endl << "Nhap ma tran vuong:";
		cout << endl << "Nhap n: ";
		cin >> n;
		Input_Matrix(b, n);
		cout << endl << "Nhap ten file de ghi: ";
		cin >> filename;
		Write_File_Matrix(filename, b, n);
		_getch();
		break;
	case 5:
		system("CLS");
		cout << endl << "Nhap ten file de doc: ";
		cin >> filename;
		n = Read_File_Staff(filename, staff);
		Output_All_Staff(staff, n);
		cout << endl << "So luong nhan co trong danh sach: " << n;
		_getch();
		break;
	case 6:
		system("CLS");
		cout << endl << "Nhap ten file de ghi: ";
		cin >> filename;
		n = 3;
		Write_File_keyStaff(filename, keyStaff, n);
		n = Read_File_Staff(filename, staff);
		Output_All_Staff(staff, n);
		cout << endl << "So luong nhan co trong danh sach: " << n;
		_getch();
		break;
	default:
		break;
	}
}