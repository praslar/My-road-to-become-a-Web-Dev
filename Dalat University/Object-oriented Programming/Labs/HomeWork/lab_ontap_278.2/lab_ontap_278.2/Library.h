void KeNgangDon()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 97; i++)
	{
		cout << KENGANGDON;
	}
	cout << '|';
}
void KeNgangDoi()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 97; i++)
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
		<< setw(10) << "Ma NV"
		<< '|'
		<< setw(10) << "Ho NV"
		<< '|'
		<< setw(15) << "Ten lot NV"
		<< '|'
		<< setw(10) << "Ten NV"
		<< '|'
		<< setw(8) << "Nam sinh"
		<< '|'
		<< setw(10) << "Luong"
		<< '|';
	KeNgangDoi();
}
//=====================================
int Read_File_Array(char *filename, Nhanvien danhsach[MAX])
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "FILE ERROR!!!";
		_getch();
		return 1;
	}
	//=============================
	char maNV[10];
	char ho[10];
	char tenLot[15];
	char ten[10];
	unsigned short int namSinh;
	double luong;
	//===============================
	int i = 0;
	in >> maNV; strcpy_s(danhsach[i].maNV, maNV);
	in >> ho; strcpy_s(danhsach[i].ho, ho);
	in >> tenLot; strcpy_s(danhsach[i].tenLot, tenLot);
	in >> ten; strcpy_s(danhsach[i].ten, ten);
	in >> namSinh; danhsach[i].namSinh = namSinh;
	in >> luong; danhsach[i].luong = luong;
	i++;
	while (!in.eof())
	{
		in >> maNV; strcpy_s(danhsach[i].maNV, maNV);
		in >> ho; strcpy_s(danhsach[i].ho, ho);
		in >> tenLot; strcpy_s(danhsach[i].tenLot, tenLot);
		in >> ten; strcpy_s(danhsach[i].ten, ten);
		in >> namSinh; danhsach[i].namSinh = namSinh;
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
		<< setw(10) << danhsach.maNV
		<< '|'
		<< setw(10) << danhsach.ho
		<< '|'
		<< setw(15) << danhsach.tenLot
		<< '|'
		<< setw(10) << danhsach.ten
		<< '|'
		<< setw(8) << danhsach.namSinh
		<< '|'
		<< setw(10) << setiosflags(ios::fixed) << setprecision(2) << danhsach.luong
		<< '|';
}
void Xuat_DSNV(Nhanvien danhsach[MAX],int n)
{
	HeadLine();
	for (int i = 0; i < n; i++)
	{
		Xuat_1NV(danhsach[i]);
		if ((i + 1) % 3 == 0)
			KeNgangDon();
	}
	cout << endl << "So luong nhan vien co trong danh sach: " << n;
}
//======================================
void Linesearch_All_MaNV(Nhanvien danhsach[MAX],int n, char maNV[10])
{
	int kiemtra = 0;
	HeadLine();
	for (int i = 0; i < n; i++)
	{
		if (strcmpi(danhsach[i].maNV,maNV) == 0)
		{
			kiemtra = 1;
			Xuat_1NV(danhsach[i]);
			KeNgangDon();
		}
	}
	if (kiemtra == 0)
	{
		cout << endl << "Khong co nhan vien co ma so " << maNV << " trong danh sach!";
	}
}