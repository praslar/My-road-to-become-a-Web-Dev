void KeNgangDon()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 96; i++)
	{
		cout << KENGANGDON;
	}
	cout << '|';
}
void KeNgangDoi()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 96; i++)
	{
		cout << KENGANGDOI;
	}
	cout << '|';
}
NODELL *GetNode(Nhanvien x)
{
	NODELL *p;
	p = new NODELL;
	if (p != NULL)
	{
		p->info = x;
		p->pNext = NULL;
	}
	return p;
}
void CreatList(LIST &list)
{
	list.pHead = list.pTail = NULL;
}
int IsEmpty(LIST list)
{
	if (list.pHead == NULL)
		return 1;
	return 0;
}
void InsertTail(LIST &list, Nhanvien x)
{
	NODELL *new_ele = GetNode(x);
	if (new_ele == NULL)
	{
		cout << endl << "Khong du bo nho!";
		_getch();
		return;
	}
	if (list.pHead == NULL)
	{
		list.pHead = new_ele;
		list.pTail = list.pHead;
	}
	else
	{
		list.pTail->pNext = new_ele;
		list.pTail = new_ele;
	}
}
void InsertHead(LIST &list, Nhanvien x)
{
	NODELL *new_ele = GetNode(x);
	if (new_ele == NULL)
	{
		cout << endl << "Khong du bo nho!";
		_getch();
		return;
	}
	if (list.pHead == NULL)
	{
		list.pHead = new_ele;
		list.pTail = list.pHead;
	}
	else
	{
		new_ele->pNext = list.pHead;
		list.pHead = new_ele;
	}
}
void Read_File_NV(char *filename, LIST &list, int &n)
{
	Nhanvien x;
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "Loi doc file!";
		_getch();
		return;
	}
	CreatList(list);
	char maNV[10];
	char ho[10];
	char tenLot[15];
	char ten[10];
	char diaChi[20];
	unsigned short int namSinh;
	double luong;
	in >> maNV; strcpy_s(x.maNV, maNV);
	in >> ho; strcpy_s(x.ho, ho);
	in >> tenLot; strcpy_s(x.tenLot, tenLot);
	in >> ten; strcpy_s(x.ten, ten);
	in >> diaChi; strcpy_s(x.diaChi, diaChi);
	in >> namSinh; x.namSinh = namSinh;
	in >> luong; x.luong = luong;
	InsertTail(list, x);
	n++;
	while (!in.eof())
	{
		in >> maNV; strcpy_s(x.maNV, maNV);
		in >> ho; strcpy_s(x.ho, ho);
		in >> tenLot; strcpy_s(x.tenLot, tenLot);
		in >> ten; strcpy_s(x.ten, ten);
		in >> diaChi; strcpy_s(x.diaChi, diaChi);
		in >> namSinh; x.namSinh = namSinh;
		in >> luong; x.luong = luong;
		InsertTail(list, x);
		n++;
	}
	in.close();
}
void HeadLine()
{
	KeNgangDoi();
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(10) << "Ma NV"
		<< '|'
		<< setw(10) << "Ho"
		<< '|'
		<< setw(15) << "Ten lot"
		<< '|'
		<< setw(10) << "Ten"
		<< '|'
		<< setw(20) << "Dia chi"
		<< '|'
		<< setw(15) << "Nam Sinh"
		<< '|'
		<< setw(10) << "Luong"
		<< '|';
	KeNgangDoi();
}
void Xuat_NV(Nhanvien x)
{
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(10) << x.maNV
		<< '|'
		<< setw(10) << x.ho
		<< '|'
		<< setw(15) << x.tenLot
		<< '|'
		<< setw(10) << x.ten
		<< '|'
		<< setw(20) << x.diaChi
		<< '|'
		<< setw(15) << x.namSinh
		<< '|'
		<< setw(10) << setiosflags(ios::fixed) << setprecision(0) << x.luong
		<< '|';
}
void Xuat_DS(LIST &list)
{
	int i = 0;
	NODELL *p;
	if (IsEmpty(list))
	{
		cout << endl << "Empty list!";
		_getch();
		return;
	}
	HeadLine();
	p = list.pHead;
	while (p != NULL)
	{
		Xuat_NV(p->info);
		p = p->pNext;
		++i;
		if ((i) % 3 == 0)
			KeNgangDon();
	}
	KeNgangDoi();
}
//==========================================================================
void Tach_Luong(LIST list, double x)
{
	NODELL *p;
	LIST list1, list2;
	p = list.pHead;
	if (p == NULL)
	{
		cout << endl << "Danh sach rong!";
		_getch();
		return;
	}
	CreatList(list1);
	CreatList(list2);
	while (p != NULL)
	{
		if (p->info.luong <= x)
			InsertTail(list1, p->info);
		else
			InsertTail(list2, p->info);
		p = p->pNext;
	}
	cout << endl << "Danh sach luong 1";
	Xuat_DS(list1);
	cout << endl << "Danh sach luong 2";
	Xuat_DS(list2);
	cout << endl;
}
void Tach_LuanPhien(LIST list)
{
	NODELL *p;
	LIST list1, list2;
	p = list.pHead;
	if (p == NULL)
	{
		cout << endl << "Danh sach rong!";
		_getch();
		return;
	}
	CreatList(list1);
	CreatList(list2);
	int k = 0;
	while (p != NULL)
	{
		if (k % 2 == 0)
			InsertTail(list1, p->info);
		else
			InsertTail(list2, p->info);
		p = p->pNext;
		k++;
	}
	cout << endl << "Danh sach luong 1";
	Xuat_DS(list1);
	cout << endl << "Danh sach luong 2";
	Xuat_DS(list2);
	cout << endl;
}
void DaoNguoc(LIST list)
{
	NODELL *p;
	LIST list1;
	p = list.pHead;
	if (p == NULL)
	{
		cout << endl << "Danh sach rong";
		_getch();
		return;
	}
	CreatList(list1);
	while (p != NULL)
	{
		InsertHead(list1, p->info);
		p = p->pNext;
	}
	Xuat_DS(list1);
	cout << endl;
}
