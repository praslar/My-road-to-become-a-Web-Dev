void KeNgangDoi()
{
	cout << endl << setiosflags(ios::left) << '|';
		for (int i = 0; i < 96; i++)
		{
			cout << NGANGDOI;
		}
		cout << '|';
}
void KeNgangDon()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 96; i++)
	{
		cout << NGANGDON;
	}
	cout << '|';
}
void TieuDe()
{
	KeNgangDoi();
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(8) << "Ma NV"
		<< '|'
		<< setw(10) << "Ho"
		<< '|'
		<< setw(10) << "Ten lot"
		<< '|'
		<< setw(10) << "Ten"
		<< '|'
		<< setw(15) << "Dia chi"
		<< '|'
		<< setw(20) << "Nam sinh"
		<< '|'
		<< setw(10) << "Luong"
		<< '|';
	KeNgangDoi();
}
NODENV* GetNode_NV(NhanVien x)
{
	NODENV *p;
	p = new NODENV;
	if (p != NULL)
	{
		p->info = x;
		p->pNext = NULL;
	}
	return p;
}
void CreatList_NV(LISTNV &list)
{
	list.pHead = list.pTail = NULL;
}
int IsEmpty(LISTNV list)
{
	if (list.pHead == NULL)
		return 1;
	return 0;
}
void InsertHead_NV(LISTNV &list, NhanVien x)
{
	NODENV* new_ele = GetNode_NV(x);
	if (new_ele == NULL)
	{
		cout << endl << "Khong du bo nho!";
		_getch();
		return;
	}
	if (list.pHead == NULL)
	{
		list.pHead == new_ele; list.pTail = list.pHead;
	}
	else
	{
		new_ele->pNext = list.pHead;
		list.pHead = new_ele;
	}
}
void InsertTail_NV(LISTNV &list, NhanVien x)
{
	NODENV* new_ele = GetNode_NV(x);
	if (new_ele == NULL)
	{
		cout << endl << "Khong du bo nho!";
		_getch();
		return;
	}
	if (list.pHead == NULL)
	{
		list.pHead = new_ele; list.pTail = list.pHead;
	}
	else
	{
		list.pTail->pNext = new_ele;
		list.pTail = new_ele;
	}
}
void File_List_NV(char *filename, LISTNV &list)
{
	NhanVien x;
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "Loi doc file!";
		_getch();
		return;
	}
	CreatList_NV(list);
	char maNV[8];
	char ho[10];
	char tenLot[10];
	char ten[10];
	char diaChi[15];
	unsigned int namSinh;
	double luong;
	in >> maNV; strcpy_s(x.maNV, 8, maNV);
	in >> ho; strcpy_s(x.ho, 10, ho);
	in >> tenLot; strcpy_s(x.tenLot, 10, tenLot);
	in >> ten; strcpy_s(x.ten, 10, ten);
	in >> diaChi; strcpy_s(x.diaChi, 15, diaChi);
	in >> namSinh; x.namSinh = namSinh;
	in >> luong; x.luong = luong;
	InsertTail_NV(list, x);
	while (!in.eof())
	{
		in >> maNV; strcpy_s(x.maNV, 8, maNV);
		in >> ho; strcpy_s(x.ho, 10, ho);
		in >> tenLot; strcpy_s(x.tenLot, 10, tenLot);
		in >> ten; strcpy_s(x.ten, 10, ten);
		in >> diaChi; strcpy_s(x.diaChi, 15, diaChi);
		in >> namSinh; x.namSinh = namSinh;
		in >> luong; x.luong = luong;
		InsertTail_NV(list, x);
	}
}
void Xuat_1NV(NhanVien x)
{
	cout << endl <<setiosflags(ios::left)
		<< '|'
		<< setw(8) << x.maNV
		<< '|'
		<< setw(10) << x.ho
		<< '|'
		<< setw(10) << x.tenLot
		<< '|'
		<< setw(10) << x.ten
		<< '|'
		<< setw(15) << x.diaChi
		<< '|'
		<< setw(20) << x.namSinh
		<< '|'
		<< setw(10) << setprecision(2) << setiosflags(ios::fixed) << x.luong
		<< '|';
}
void Xuat_DSNV(LISTNV list,int &n)
{
	NODENV *p;
	if (IsEmpty(list))
	{
		cout << endl << "Danh sach rong!";
		return;
	}
	TieuDe();
	p = list.pHead;
	while (p != NULL)
	{
		Xuat_1NV(p->info);
		if ((n + 1) % 5 == 0)
			KeNgangDon();
		p = p->pNext;
		n++;
	}
	KeNgangDoi();
	cout << endl << "So nhan vien hien tai: " << n;
}