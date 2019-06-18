void Nhap_1NV(NhanVien &p)
{
	cout << endl << "Ma NV: ";
	_flushall();
	gets_s(p.maNV, 8);
	gets_s(p.maNV, 8);
	cout << "Ho: ";
	_flushall();
	gets_s(p.ho, 10);
	cout << "Ten Lot: ";
	_flushall();
	gets_s(p.tenLot, 10);
	cout << "Ten nhan vien: ";
	_flushall();
	gets_s(p.ten, 7);
	cout << "Ngay sinh: ";
	_flushall();
	cin >> p.ntns.Ngay;
	cout << "Thang sinh: ";
	_flushall();
	cin >> p.ntns.Thang;
	cout << "Nam sinh: ";
	_flushall();
	cin >> p.ntns.Nam;
	cout << "Dia chi NV: ";
	_flushall();
	gets_s(p.diaChi, 20);
	gets_s(p.diaChi, 20);
	cout << "Luong NV: ";
	_flushall();
	cin >> p.luong;
}
void Nhap_DSNV(NhanVien a[MAX], int &n)
{
	int i;
	cout << endl << "Nhap so luong nhan vien: ";
	cin >> n;
	for (i = 0; i < n; i++)
	{
		system("CLS");
		cout << endl << "Nhan vien [" << i + 1 << "] -> Nhap thong tin cho NV ::";
		Nhap_1NV(a[i]);
	}
}
void KeNgang()
{
	int i;
	cout << endl;
	cout << setiosflags(ios::left) << "|";
	for (i = 0; i < 108; i++)
	{
		cout << NGANDOI;
	}
	cout << "|";
}
void TieuDe()
{
	KeNgang();
	cout << endl << setiosflags(ios::left)
		<< '|' << setw(8) << "Ma NV"
		<< '|' << setw(16) << "Ho"
		<< '|' << setw(20) << "Ten Lot"
		<< '|' << setw(8) << "Ten"
		<< '|' << setw(12) << "Ngay Sinh(dd/mm/yy)"
		<< '|' << setw(16) << "Dia Chi"
		<< '|' << setw(15) << "Luong"
		<< '|';
	KeNgang();
}
void Xuat_1NV(NhanVien p)
{
	cout << endl << setiosflags(ios::left)
		<< '|' << setw(8) << p.maNV
		<< '|' << setw(16) << p.ho
		<< '|' << setw(20) << p.tenLot
		<< '|' << setw(8) << p.ten
		<< '|' << setw(2) << p.ntns.Ngay
		<< '/' << setw(2) << p.ntns.Thang
		<< '/' << setw(13) << p.ntns.Nam
		<< '|' << setw(16) << p.diaChi
		<< '|' << setw(15) << setiosflags(ios::fixed) << setprecision(0) << p.luong
		<< '|';
}
void Xuat_DSNV(NhanVien a[MAX], int n)
{
	int i;
	TieuDe();
	for (i = 0; i < n; i++)
	{
		cout << endl;
		Xuat_1NV(a[i]);
	}
	KeNgang();
}
void Them_NV_Cuoi(NhanVien a[MAX], int &n, NhanVien p)
{
	a[n++] = p;
}
void Xoa_NV_MaNV(NhanVien a[MAX], int &n, char maNV[8])
{
	int i;
	for (i = 0; i < n; i++)
		if (strcmp(a[i].maNV, maNV) == 0)
			break;
	if (i == n)
	{
		cout << endl << "Loi xac dinh ma NV: " << maNV;
		return;
	}
	for (int j = i + 1; j < n; j++)
		a[j - 1] = a[j];
	n--;
}
void Sua_NV_MaNV(NhanVien a[MAX], int &n, char maNV[8])
{
	int i;
	char tl;
	for (i = 0; i < n; i++)
		if (strcmp(a[i].maNV, maNV) == 0)
			break;
	if (i == n)
	{
		cout << endl << "Loi xac dinh ma NV: " << maNV;
		return;
	}
	system("CLS");
	TieuDe();
	Xuat_1NV(a[i]);
	KeNgang();
	cout << endl << "::Correct Information::";
	cout << endl << "Press y(YES) to correct.";
	cout << endl << "Press n(NO) to continue.";
	KeNgang();
	cout << endl << "Ma NV(y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Ma NV : ";
		_flushall();
		gets_s(a[i].maNV, 8);
		gets_s(a[i].maNV, 8);
	}
	cout << endl << "Ho(y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Ho : ";
		_flushall();
		gets_s(a[i].ho, 10);
	}
	cout << endl << "Ten lot (y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Ten lot: ";
		_flushall();
		gets_s(a[i].tenLot, 20);
	}
	cout << endl << "Ten (y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Ten: ";
		_flushall();
		gets_s(a[i].ten, 7);
	}
	cout << endl << "Ngay sinh(y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Ngay sinh: ";
		_flushall();
		cin >> a[i].ntns.Ngay;
	}
	cout << endl << "Thang sinh(y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Thang sinh: ";
		_flushall();
		cin >> a[i].ntns.Thang;
	}
	cout << endl << "Nam sinh(y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Nam sinh: ";
		_flushall();
		cin >> a[i].ntns.Nam;
	}
	cout << endl << "Dia chi (y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Dia chi: ";
		_flushall();
		gets_s(a[i].diaChi, 21);
		gets_s(a[i].diaChi, 21);
	}
	cout << endl << "Luong (y/n)?";
	tl = _getch();
	if (tl != 'n' && tl != 'N')
	{
		cout << "Luong: ";
		_flushall();
		cin >> a[i].luong;
	}
}
int Tim_NV_MaNV(NhanVien a[MAX], int &n, char maNV[8])
{
	int i, kq = 0;
	for (i = 0; i < n; i++)
		if (strcmp(a[i].maNV, maNV) == 0)
		{
			kq = i;
			break;
		}
	return kq;
}
void Tim_NV_Ten(NhanVien a[MAX], int &n, char ten[10])
{
int i, dem = 0;
for (i = 0; i < n; i++)
	if (strcmp(a[i].ten, ten) == 0)
		dem++;
if (dem == 0)
cout << endl << "Loi xac dinh ten: " << ten;
else
{
	cout << endl << "So luong nhan vien ten '" << ten << "': " << dem;
	cout << endl << "::Result::";
	TieuDe();
	KeNgang();
	for (i = 0; i < n; i++)
	{
		if (strcmp(a[i].ten, ten) == 0)
		{
			cout << endl;
			Xuat_1NV(a[i]);
		}
	}
}

}
void Bubble(NhanVien &p, NhanVien &q)
{
	NhanVien temp;
	temp = p;
	p = q;
	q = temp;
}
void Sap_Tang_MaNV(NhanVien a[MAX], int n)
{
	int i, j;
	for (i = 0; i < n - 1; i++)
		for (j = i + 1; j < n; j++)
		{
			if (strcmpi(a[i].maNV, a[j].maNV) > 0)
				Bubble(a[i], a[j]);
		}
}
void Sap_Tang_Ho_TenLot_Ten_Luong(NhanVien a[MAX], int n)
{
	int i, j;
	//Sap tang theo ten
	for (i = 0; i < n - 1; i++)
		for (j = i + 1; j < n; j++)
			if (strcmpi(a[i].ten, a[j].ten) > 0)
				Bubble(a[i], a[j]);
	//Sap tang theo ho
	for (i = 0; i < n - 1; i++)
		for (j = i + 1; j < n; j++)
			if (strcmpi(a[i].ten, a[j].ten) == 0)
				if (strcmpi(a[i].ho, a[j].ho) > 0)
					Bubble(a[i], a[j]);
	//Sap tang theo luong
	for (i = 0; i < n - 1; i++)
		for (j = i + 1; j < n; j++)
			if (strcmpi(a[i].ten, a[j].ten) == 0 && strcmpi(a[i].ho, a[j].ho) == 0)
				if (a[i].luong > a[j].luong)
					Bubble(a[i], a[j]);


}
double Tong_Luong_NV(NhanVien a[MAX], int n)
{
	int i;
	double sum = 0;
	for (i = 0; i < n; i++)
	{
		sum += a[i].luong;
	}
	return sum;
}
void Tim_NV_Luong(NhanVien a[MAX], int n, double x)
{
	int i, dem = 0;
	for (i = 0; i < n; i++)
		if (a[i].luong >= x)
			dem++;
	if (dem == 0)
	{
		cout << endl << "Khong co nhan vien nao co luong lon hon " << x;
		return;
	}
	else
	{
		cout << endl << "So luong nhan vien co luong >= " << x << ": " << dem;
		cout << endl << "::Result::";
		TieuDe();
		KeNgang();
		for (i = 0; i < n; i++)
			if (a[i].luong >= x)
			{
				cout << endl;
				Xuat_1NV(a[i]);
			}
		KeNgang();
	}
}
void Tim_NV_NamSinh(NhanVien a[MAX], int n, unsigned int h,unsigned int t)
{
	int i, dem = 0;
	for (i = 0; i < n; i++)
		if (h <= a[i].ntns.Nam && a[i].ntns.Nam <= t)
			dem++;
	if (dem == 0)
	{
		cout << endl << "Khong co nhan vien nao sinh tu nam " << h << " -> " << t;
		return;
	}
	else
	{
		cout << endl << "So luong nhan vien co nam sinh tu " << h << "-> " << t << ": " << dem;
		cout << endl << "::Result::";
		TieuDe();
		KeNgang();
		for (i = 0; i < n; i++)
			if (h <= a[i].ntns.Nam && a[i].ntns.Nam <= t)
			{
				cout << endl;
				Xuat_1NV(a[i]);
			}
		KeNgang();
	}
}
void Chen_NV(char maNV[8], char ho[10], char tenLot[20], char ten[10], Byte Ngay, Byte Thang, unsigned int namSinh, char diaChi[21], double luong, NhanVien a[MAX], int&n)
{
	strcpy_s(a[n].maNV, 8, maNV);
	strcpy_s(a[n].ho, 10, ho);
	strcpy_s(a[n].tenLot, 20, tenLot);
	strcpy_s(a[n].ten, 20, ten);
	a[n].ntns.Ngay = Ngay;
	a[n].ntns.Thang = Thang;
	a[n].ntns.Nam = namSinh;
	strcpy_s(a[n].diaChi,21, diaChi);
	a[n].luong = luong;
	n++;
}
void TaoDanhSachNhanVien(NhanVien a[MAX], int &n)
{
	Chen_NV("1234507", "Nguyen","Van", "Tan", 1, 1, 1990, "Da Lat", 20345678.0, a, n);
	Chen_NV("1205507", "Tran ","Minh", "Hoang", 10, 10, 1980, "Qui Nhon", 14345678.0, a, n);
	Chen_NV("2234067", "Truong","_", "Hoang", 10, 12, 1980, "Da Lat", 10342678.0, a, n);
	Chen_NV("2134167", "Le","Tuan", "Ban", 10, 1, 1975, "Quang Nam", 18349678.0, a, n);
	Chen_NV("1135067", "Tran ","Minh", "Ban", 5, 6, 1977, "Phu Yen", 12345978.0, a, n);
	Chen_NV("1034007", "Truong","_", "Hoang", 21, 12, 1987, "Da Lat", 15348678.0, a, n);
	Chen_NV("1130160", "Vo ","Tuan", "Trong", 1, 11, 1985, "Qui Nhon", 20341178.0, a, n);
	Chen_NV("1235567", "Hoang","Van", "Tan", 15, 12, 1970, "Phu Yen", 22300970.0, a, n);
	Chen_NV("1034327", "Tran"," Van", "Vu", 11, 11, 1982, "Da Lat", 16348888.0, a, n);
	Chen_NV("1034467", "Hoang","Trong", "Ban", 12, 1, 1980, "Nha Trang", 14365698.0, a, n);
	Chen_NV("1134467", "Van" ,"Quoc", "Cuong", 1, 10, 1960, "Nha Trang", 24300000.0, a, n);
	Chen_NV("1533407", "Truong","_", "Hoang", 1, 12, 1967, "Da Nang", 16340000.0, a, n);
}

