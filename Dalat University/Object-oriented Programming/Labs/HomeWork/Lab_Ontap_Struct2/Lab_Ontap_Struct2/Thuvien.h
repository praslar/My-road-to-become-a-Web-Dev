void KeNgangDoi()
{
	cout << endl;
	cout << setiosflags(ios::left) << '|';
	for (int i = 0; i < 96; i++)
		cout << NGANGDOI;
	cout << '|';
}
void KeNgangDon()
{
	cout << endl;
	cout << setiosflags(ios::left) << '|';
	for (int i = 0; i < 96; i++)
		cout << NGANGDON;
	cout << '|';
}
void TieuDe()
{
	KeNgangDoi();
	cout << endl;
	cout << setiosflags(ios::left)
		<< '|'
		<< setw(10) << "MaSV" 
		<< '|'
		<< setw(20) << "Ho" 
		<< '|'
		<< setw(10) << "Ten"
		<< '|'
		<< setw(10) << "GT"
		<< '|'
		<< setw(10) << "NS" 
		<< '|'
		<< setw(20) << "Que quan"
		<< '|'
		<< setw(10) << "Lop" 
		<<'|';
	KeNgangDon();
}
void TieuDeBangDiem()
{
	KeNgangDoi();
	cout << endl;
	cout << setiosflags(ios::left) << '|'
		<< setw(9) << "maSV" << '|'
		<< setw(15) << "diemLab" << '|'
		<< setw(15) << "diemGK" << '|'
		<< setw(15) << "diemCK" << '|'
		<< setw(15) << "diemTK" << '|';
	KeNgangDoi();
}
void TieuDeBangDiemChinhThuc()
{
	KeNgangDoi();
	cout << endl;
	cout << setiosflags(ios::left)
		<< '|'
		<< setw(10) << "MaSV"
		<< '|'
		<< setw(20) << "Ho"
		<< '|'
		<< setw(10) << "Ten"
		<< '|'
		<< setw(10) << "GT"
		<< '|'
		<< setw(10) << "NS"
		<< '|'
		<< setw(20) << "Que quan"
		<< '|'
		<< setw(10) << "Lop"
		<< '|'
		<< setw(10) << "Diem TK"
		<< '|';
	KeNgangDoi();
}
void Xuat_DS_1SV(SinhVien p)
{
	cout << setiosflags(ios::left)
		<< '|'
		<< setw(10) << p.maSV
		<< '|'
		<< setw(20) << p.ho 
		<< '|'
		<< setw(10) << p.ten
		<< '|'
		<< setw(10) << p.gioiTinh 
		<< '|'
		<< setw(10) << p.namSinh
		<< '|'
		<< setw(20) << p.queQuan
		<< '|'
		<< setw(10) << p.lop
		<< '|';
}
void Xuat_DS_Lop(SinhVien a[MAX], int &n)
{
	int i;
	TieuDe();
	for (i = 0; i < n; i++)
	{
		cout << endl;
		Xuat_DS_1SV(a[i]);
		if ((i+1) % 5 == 0)
			KeNgangDon();
	}
	KeNgangDoi();
}
void Chen_SV(char maSV[8], char ho[15], char ten[8],char gioiTinh[4],unsigned int namSinh,char queQuan[15],char lop[6], SinhVien a[MAX], int &n)
{
	if (n < MAX)
	{
		strcpy_s(a[n].maSV, 8,maSV);
		strcpy_s(a[n].ho, 15,ho);
		strcpy_s(a[n].ten,8, ten);
		strcpy_s(a[n].gioiTinh,4, gioiTinh);
		a[n].namSinh = namSinh;
		strcpy_s(a[n].queQuan,15, queQuan);
		strcpy_s(a[n].lop,6, lop);
		n++;
	}
}
void Tao_DS_SV(SinhVien a[MAX], int &n)
{
	n = 0;
	Chen_SV("1512967", "Trieu", "Minh", "Nu", 1997, "Ninh Thuan", "CTK39", a, n);
	Chen_SV("1510279", "Nguyen Van", "Tan", "Nam", 1997, "Da Lat", "CTK39", a, n);
	Chen_SV("1512555", "Tran Tuan", "Ngoc", "Nam", 1996, "Khanh Hoa", "CTK39", a, n);
	Chen_SV("1412120", "Vo Thi", "Hoa", "Nu", 1996, "Binh Dinh", "CTK38", a, n);
	Chen_SV("1313320", "Le Ngoc", "Minh", "Nam", 1995, "Can Tho", "CTK37", a, n);
	Chen_SV("1510214", "Dinh Thi", "Ngoc", "Nu", 1997, "Da Lat", "CTK39", a, n);
	Chen_SV("1512128", "Ta Van", "Ton", "Nam", 1997, "Binh Dinh", "CTK39", a, n);
	Chen_SV("1512868", "Doan", "Du", "Nam", 1996, "Da Lat", "CTK39", a, n);
	Chen_SV("1512887", "Vuong Ngoc", "Yen", "Nu", 1997, "Da Nang", "CTK39", a, n);
	Chen_SV("1514205", "Vuong Trung", "Duong", "Nam", 1995, "Phu Yen", "CTK39", a, n);
	Chen_SV("1510192", "Nhac Linh", "San", "Nu", 1997, "Da Lant", "CTK39", a, n);
	Chen_SV("1312890", "Hoang", "Dung", "Nu", 1995, "Da Nang", "CTK37", a, n);
	Chen_SV("1444405", "Truong Vo", "Ky", "Nam", 1996, "Binh Dinh", "CTK38", a, n);
	Chen_SV("1512988", "Vi Tieu", "Bao", "Nam", 1996, "Da Lat", "CTK39", a, n);
}
void Xuat_Diem_1SV(BangDiem p)
{
	cout << setiosflags(ios::left) << '|'
	 << setw(9) << p.maSV << '|'
	 << setw(15) << p.diemLab << '|'
	 << setw(15) << p.diemGK << '|'
	 << setw(15) << p.diemCK << '|'
	 << setw(15) << p.diemTK << '|';
}
void Xuat_Diem_Lop(BangDiem b[MAX], int &n)
{
	int i;
	TieuDeBangDiem();
	for ( i = 0; i < n; i++)
	{
		cout << endl;
		Xuat_Diem_1SV(b[i]);
		if ((i + 1) % 5 == 0)
			KeNgangDon();
	}
}
void Chen_Diem(char maSV[8], double diemLab, double diemGK, double diemCK,  BangDiem b[MAX], int &n)
{
	if (n < MAX)
	{
		strcpy_s(b[n].maSV, 8, maSV);
		b[n].diemLab = diemLab;
		b[n].diemGK = diemLab;
		b[n].diemCK = diemCK;
		n++;
	}
}
void Tao_BangDiem_SV(BangDiem b[MAX], int &n)
{
	n = 0;
	Chen_Diem("1512967", 9, 8, 6, b, n);
	Chen_Diem("1510279", 10, 6, 5, b, n);
	Chen_Diem("1512555", 8, 5, 7, b, n);
	Chen_Diem("1412120", 9.5, 9, 8, b, n);
	Chen_Diem("1313320", 8, 8, 4, b, n);
	Chen_Diem("1510214", 8.5, 8, 6, b, n);
	Chen_Diem("1512128", 9, 9, 9, b, n);
	Chen_Diem("1512868", 10, 8.5, 8.5, b, n);
	Chen_Diem("1512887", 7, 7, 7, b, n);
	Chen_Diem("1514205", 8, 8, 8.5, b, n);
	Chen_Diem("1510192", 10, 9, 9, b, n);
	Chen_Diem("1312890", 9, 9, 8, b, n);
	Chen_Diem("1444405", 7, 5, 5, b, n);
	Chen_Diem("1512988", 8.5, 8, 8, b, n);
}
void TinhDiemT-ongKet(BangDiem b[MAX], int &n)
{
	int i;
	double sum;
	for ( i = 0; i < n; i++)
	{
		sum = b[i].diemLab* 0.2 + b[i].diemGK *0.2 + b[i].diemCK *0.6;
		b[i].diemTK = sum;
	}
}