int doc_file(char *filename, nhanvien ds[MAX])
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "SYSTEM ERORR!\n";
		cout << endl << "----Nhap lai ten file----";
		return 1;
	}
	char maNV[8];
	char hoNV[10];
	char tenLot[10];
	char ten[10];
	char diachi[12];
	int namSinh;
	double luong;
	int i = 0;
	in >> maNV;	strcpy_s(ds[i].maNV, maNV);
	in >> hoNV; strcpy_s(ds[i].hoNV, hoNV);
	in >> tenLot; strcpy_s(ds[i].tenLot, tenLot);
	in >> ten; strcpy_s(ds[i].ten, ten);
	in >> diachi; strcpy_s(ds[i].diachi, diachi);
	in >> namSinh; ds[i].namSinh = namSinh;
	in >> luong; ds[i].luong = luong;
	while (!in.eof())
	{
		i++;
		in >> maNV;	strcpy_s(ds[i].maNV, maNV);
		in >> hoNV; strcpy_s(ds[i].hoNV, hoNV);
		in >> tenLot; strcpy_s(ds[i].tenLot, tenLot);
		in >> ten; strcpy_s(ds[i].ten, ten);
		in >> diachi; strcpy_s(ds[i].diachi, diachi);
		in >> namSinh; ds[i].namSinh = namSinh;
		in >> luong; ds[i].luong = luong;
	}
	in.close();
	return i;
}
void TieuDe()
{
	cout << endl << "=========================================================================\n";
	cout << setiosflags(ios::left);
	cout << setw(10) << "Ma NV"
		<< setw(10) << "Ho"
		<< setw(10) << "Ten Lot"
		<< setw(10) << "Ten"
		<< setw(10) << "Dia Chi"
		<< setw(10) << "NSinh"
		<< setw(20) <<setprecision(0) << setiosflags(ios::fixed) << "Luong";
	cout << endl << "=========================================================================\n";
}
void Xuat_DS(nhanvien ds[MAX], int n)
{
	TieuDe();
	for (int i = 0; i < n; i++)
	{
		cout << setw(10) << ds[i].maNV
			<< setw(10) << ds[i].hoNV
			<< setw(10) << ds[i].tenLot
			<< setw(10) << ds[i].ten
			<< setw(10) << ds[i].diachi
			<< setw(10) << ds[i].namSinh
			<< setw(20) << ds[i].luong;
		cout << endl;
	}
}
