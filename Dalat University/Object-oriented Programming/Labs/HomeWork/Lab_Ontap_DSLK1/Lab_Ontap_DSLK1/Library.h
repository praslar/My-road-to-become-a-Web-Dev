void SingleCross()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 103; i++)
	{
		cout << KENGANGDON;
	}
	cout << '|';
}
void DoubleCross()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 103; i++)
	{
		cout << KENGANGDOI;
	}
	cout << '|';
}
void HeadLine()
{
	DoubleCross();
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(10) << "Ma SV"
		<< '|'
		<< setw(15) << "Ho SV"
		<< '|'
		<< setw(15) << "Ten SV"
		<< '|'
		<< setw(15) << "Nam Sinh"
		<< '|'
		<< setw(5) << "Diem GK"
		<< '|';
	DoubleCross();
}
//====================================
NODELL* GetNode_LL(LLSinhVien x)
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
void CreatList_LL(LISTLL &list)
{
	list.pHead = list.pTail = NULL;
}
void InsertTail_LL(LISTLL &list, LLSinhVien x)
{
	NODELL* new_ele = GetNode_LL(x);
	if (new_ele == NULL)
	{
		cout << endl << "Khong du bo nho!";
		system("CLS");
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
void File_List_LL(char *filename, LISTLL &list)
{
	LLSinhVien x;
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "Loi mo file!";
		_getch();
		return;
	}
	CreatList_LL(list);
	char maSV[8];
	char ho[15];
	char ten[15];
	unsigned short int namSinh;
	char nguyenQuan[20];
	in >> maSV; strcpy_s(x.maSV, maSV);
	in >> ho; strcpy_s(x.ho, ho);
	in >> ten; strcpy_s(x.ten, ten);
	in >> namSinh; x.namSinh = namSinh;
	in >> nguyenQuan; strcpy_s(x.nguyenQuan, nguyenQuan);
	InsertTail_LL(list, x);
	while (!in.eof())
	{
		in >> maSV; strcpy_s(x.maSV, maSV);
		in >> ho; strcpy_s(x.ho, ho);
		in >> ten; strcpy_s(x.ten, ten);
		in >> namSinh; x.namSinh = namSinh;
		in >> nguyenQuan; strcpy_s(x.nguyenQuan, nguyenQuan);
		InsertTail_LL(list, x);
	}
	in.close();
}
//=====================================
NODEBD* GetNode_BD(DiemTK x)
{
	NODEBD *p;
	p = new NODEBD;
	if (p != NULL)
	{
		p->info = x;
		p->pNext = NULL;
	}
	return p;
}
void CreatList_BD(LISTBD &list)
{
	list.pHead = list.pTail = NULL;
}
void InsertTail_BD(LISTBD &list, DiemTK x)
{
	NODEBD* new_ele = GetNode_BD(x);
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
void File_List_BD(char *filename, LISTBD &list)
{
	DiemTK x;
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "Loi doc file!";
		_getch();
		return;
	}
	CreatList_BD(list);
	char maSV[8];
	double diemCC;
	double diemBL;
	double diemKT;
	double dgk;
	in >> maSV; strcpy_s(x.maSV, maSV);
	in >> diemCC; x.diemCC = diemCC;
	in >> diemBL; x.diemBL = diemBL;
	in >> diemKT; x.diemKT = diemBL;
	dgk = diemCC + diemBL + diemKT; x.dgk = dgk;
	InsertTail_BD(list, x);
	while (!in.eof())
	{
		in >> maSV; strcpy_s(x.maSV, maSV);
		in >> diemCC; x.diemCC = diemCC;
		in >> diemBL; x.diemBL = diemBL;
		in >> diemKT; x.diemKT = diemBL;
		dgk = diemCC + diemBL + diemKT; x.dgk = dgk;
		InsertTail_BD(list, x);
	}
	in.close();
}
//=======================================
void OutPut_BD(LISTLL ll, LISTBD bd)
{
	int i = 0;
	HeadLine();
	NODELL *p = ll.pHead;
	NODEBD *q = bd.pHead;
	while (p!=NULL && q!= NULL)
	{
		cout << endl << setiosflags(ios::left)
			<< '|'
			<< setw(10) << p->info.maSV
			<< '|'
			<< setw(15) << p->info.ho
			<< '|'
			<< setw(15) << p->info.ten
			<< '|'
			<< setw(15) << p->info.namSinh
			<< '|'
			<< setw(5) << setprecision(2) << setiosflags(ios::fixed) << q->info.dgk
			<< '|';
		p = p->pNext;
		q = q->pNext;
		i++;
		if ((i + 1) % 3 == 0)
			SingleCross();
	}
}