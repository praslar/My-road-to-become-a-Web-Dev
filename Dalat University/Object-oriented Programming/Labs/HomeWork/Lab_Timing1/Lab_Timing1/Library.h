void KeNgangDon()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 91; i++)
	{
		cout << KENGANGDON;
	}
	cout << '|';
}
void KeNgangDoi()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 91; i++)
	{
		cout << KENGANGDOI;
	}
	cout << '|';
}
void HeadLine()
{
	KeNgangDoi();
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(8) << "Ma NV"
		<< '|'
		<< setw(12) << "Ho"
		<< '|'
		<< setw(10) << "Ten lot"
		<< '|'
		<< setw(10) << "Ten"
		<< '|'
		<< setw(15) << "Dia chi"
		<< '|'
		<< setw(20) << "Ngay sinh(dd/mm/yy)"
		<< '|'
		<< setw(10) << "Luong"
		<< '|';
	KeNgangDoi();
}
//===========================================
int Read_File_Array(char *filename, Nhanvien danhsach[MAX])
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "File error!!!";
		_getch();
		return 1;
	}
	unsigned short int ngay;
	unsigned short int thang;
	unsigned short int nam;
	char maNV[8];
	char ho[12];
	char tenLot[10];
	char ten[10];
	char diaChi[15];
	Namsinh ngaythangnamsinh;
	double luong;
	int i = 0;
	in >> maNV; strcpy_s(danhsach[i].maNV, maNV);
	in >> ho; strcpy_s(danhsach[i].ho, ho);
	in >> tenLot; strcpy_s(danhsach[i].tenLot, tenLot);
	in >> ten; strcpy_s(danhsach[i].ten, ten);
	in >> diaChi; strcpy_s(danhsach[i].diaChi, diaChi);
	in >> ngay; danhsach[i].ngaythangnamsinh.ngay = ngay;
	in >> thang; danhsach[i].ngaythangnamsinh.thang = thang;
	in >> nam; danhsach[i].ngaythangnamsinh.nam = nam;
	in >> luong; danhsach[i].luong = luong;
	i++;
	while (!in.eof())
	{
		in >> maNV; strcpy_s(danhsach[i].maNV, maNV);
		in >> ho; strcpy_s(danhsach[i].ho, ho);
		in >> tenLot; strcpy_s(danhsach[i].tenLot, tenLot);
		in >> ten; strcpy_s(danhsach[i].ten, ten);
		in >> diaChi; strcpy_s(danhsach[i].diaChi, diaChi);
		in >> ngay; danhsach[i].ngaythangnamsinh.ngay = ngay;
		in >> thang; danhsach[i].ngaythangnamsinh.thang = thang;
		in >> nam; danhsach[i].ngaythangnamsinh.nam = nam;
		in >> luong; danhsach[i].luong = luong;
		i++;
	}
	in.close();
	return i;
}
void Xuat_1NV(Nhanvien danhsach)
{
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(8) << danhsach.maNV
		<< '|'
		<< setw(12) << danhsach.ho
		<< '|'
		<< setw(10) << danhsach.tenLot
		<< '|'
		<< setw(10) << danhsach.ten
		<< '|'
		<< setw(15) << danhsach.diaChi
		<< '|'
		<< setw(2) << danhsach.ngaythangnamsinh.ngay
		<< '/'
		<< setw(2) << danhsach.ngaythangnamsinh.thang
		<< '/'
		<< setw(14) << danhsach.ngaythangnamsinh.nam
		<< '|'
		<< setw(10) << setiosflags(ios::fixed) << setprecision(0) << danhsach.luong
		<< '|';
}
void Xuat_DSNV(Nhanvien danhsach[MAX], int n)
{
	HeadLine();
	if (n == 0)
	{
		cout << endl << "Danh sach rong!";
		_getch();
		return;
	}
	for (int i = 0; i < n; i++)
	{
		Xuat_1NV(danhsach[i]);
		if ((i + 1) % 4 == 0)
			KeNgangDon();
	}
	cout << endl << "So luong nhan vien co trong danh sach: " << n;
}