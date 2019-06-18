void XuatMenu()
{
	KeNgangDoi();
	cout << endl << "                                  <HE THONG CHUC NANG>";
	cout << endl << "0.Thoat khoi chuong trinh.";
	cout << endl << "1.Nhap du lieu cho mang va xem mang.";
	cout << endl << "2.Chon Truc tiep - tai moi buoc dua GTNN ve dau mang.";
	cout << endl << "3.Tra ve chi so i dau tien neu co";
	cout << endl << "4.Tra ve chi so i dau tien neu co(Co linh canh)";
	cout << endl << "5.Tra ve chi so i cuoi cung neu co";
	cout << endl << "6.Tra ve tat ca chi so i cuoi cung neu co.";
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
	char filename[20];
	int kq, x;
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << endl << "==================PRESS ANY KEY TO EXIT=====================";
		_getch();
		break;
	case 1:
		system("CLS");
		cout << endl << "Nhap ten file I de doc: ";
		cin >> filename;
		Read_File_Array(filename, a, n1);
		Xuat_Array(a, n1);
		cout << endl << "Nhap ten file II de doc: ";
		cin >> filename;
		Read_File_Array(filename, b, n2);
		Xuat_Array(b, n2);
		_getch();
		break;
	case 2:
		system("CLS");
		cout << endl << "Mang hien hanh: \n";
		Xuat_Array(a, n1);
		cout << endl;
		Selection_L(a, n1);
		cout << endl << "Sap xep tang mang: \n";
		Xuat_Array(a, n1);
		cout << endl;
		_getch();
	case 3:
		system("CLS");
		cout << endl << "Mang hien hanh:\n";
		Xuat_Array(a, n1);
		cout << endl << "Nhap chi so tim kiem x: ";
		cin >> x;
		kq = Linesearch_Fisrt(a, n1,x);
		if (kq == -1)
			cout << endl << x << "khong co trong day a!";
		else
			cout << endl << "Chi so cua pt dau tien == " << x << " la " << kq;
		_getch();
		break;
	case 4:
		system("CLS");
		cout << endl << "Mang hien hanh:\n";
		Xuat_Array(a, n1);
		cout << endl << "Nhap chi so tim kiem x: ";
		cin >> x;
		kq = Linesearch_First_(a, n1, x);
		if (kq == -1)
			cout << endl << x << "khong co trong day a!";
		else
			cout << endl << "Chi so cua pt dau tien == " << x << " la " << kq;
		_getch();
		break;
	case 5:
		system("CLS");
		cout << endl << "Mang hien hanh:\n";
		Xuat_Array(a, n1);
		cout << endl << "Nhap chi so tim kiem x: ";
		cin >> x;
		kq = Linesearch_End_(a, n1, x);
		if (kq == -1)
			cout << endl << x << "khong co trong day a!";
		else
			cout << endl << "Chi so cua pt cuoi cung == " << x << " la " << kq;
		_getch();
		break;
	case 6:
		cout << endl << "Mang hien hanh:\n";
		Xuat_Array(a, n1);
		cout << endl << "Nhap chi so tim kiem x: ";
		cin >> x;
		cout << endl << "Tra ve tat ca chi so i cuoi cung neu co ";
		Linesearch_All(a, n1, x);
		_getch();
		break;
	default:
		break;
	}
}