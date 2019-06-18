//Tao nut moi LLSV
NODELLSV* GetNode_LLSV(LyLichSinhVien x)
{
	NODELLSV *p;
	p = new NODELLSV;
	if (p != NULL)
	{
		p->info = x;
		p->pNext = NULL;
	}
	return p;
}
//Khoi tao DSLK rong
void CreatList_LLSV(LISTLLSV &list)
{
	list.pHead = list.pTail = NULL;
}
//Chen x vao cuoi danh sach
void InsertTail_LLSV(LISTLLSV &list, LyLichSinhVien x)
{
	NODELLSV* new_ele = GetNode_LLSV(x);
	if (new_ele == NULL)
	{
		cout << endl << "ERROR! DISC FULL";
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
//Chuyen du lieu tap tin diem thanh phan sang LISTLLSV
void File_List_LLSV(char *filename, LISTLLSV &list)
{
	LyLichSinhVien x;
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "UNABLE TO ACCESS THE FILE!";
		_getch();
		exit(1);
	}
	CreatList_LLSV(list);
	char maSV[8];
	char ho[20];
	char ten[10];
	unsigned int namSinh;
	char nguyenQuan[20];
	in >> maSV; strcpy_s(x.maSV, 8, maSV);
	in >> ho; strcpy_s(x.ho, 20, ho);
	in >> ten; strcpy_s(x.ten, 10, ten);
	in >> namSinh; x.namSinh = namSinh;
	in >> nguyenQuan; strcpy_s(x.nguyenQuan, 20, nguyenQuan);
	InsertTail_LLSV(list, x);
	while (!in.eof())
	{
		in >> maSV; strcpy_s(x.maSV, 8, maSV);
		in >> ho; strcpy_s(x.ho, 20, ho);
		in >> ten; strcpy_s(x.ten, 10, ten);
		in >> namSinh; x.namSinh = namSinh;
		in >> nguyenQuan; strcpy_s(x.nguyenQuan, 20, nguyenQuan);
		InsertTail_LLSV(list, x);
	}
	in.close();
}
//================================================================
//Bang diem
//Tao nuy moi DTB
NODEDTB* GetNode_DTB(DiemTB x)
{
	NODEDTB *p;
	p = new NODEDTB;
	if (p != NULL)
	{
		p->info = x;
		p->pNext = NULL;
	}
	return p;
}
//Tao list DTB rong
void CreatList_DTB(LISTDTB &list)
{
	list.pHead = NULL;
	list.pTail = NULL;
}
//Chen Diem vao cuoi danh sach
void InsertTail_DTB(LISTDTB &list, DiemTB x)
{
	NODEDTB* new_ele = GetNode_DTB(x);
	if (new_ele == NULL)
	{
		cout << endl << "DISC FULL!";
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
//CHuyen du lieu tap tin diem thanh phan sang List BD
void File_List_DTB(char *filename, LISTDTB &list)
{
	DiemTB x;
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "UNABLE TO ACCESS THE FILE!";
		_getch();
		return;
	}
	CreatList_DTB(list);
	char maSV[8];
	double diemChuyenCan;
	double diemBaiLab;
	double diemKiemTra;
	double diemGiuaKi;
	in >> maSV; strcpy_s(x.maSV, 8, maSV);
	in >> diemChuyenCan; x.diemChuyenCan = diemChuyenCan;
	in >> diemBaiLab; x.diemBaiLab = diemBaiLab;
	in >> diemKiemTra; x.diemKiemTra = diemKiemTra;
	diemGiuaKi = diemChuyenCan + diemBaiLab + diemKiemTra; x.diemGiuaKi = diemGiuaKi;
	InsertTail_DTB(list, x);
	while (!in.eof())
	{
		in >> maSV; strcpy_s(x.maSV, 8, maSV);
		in >> diemChuyenCan; x.diemChuyenCan = diemChuyenCan;
		in >> diemBaiLab; x.diemBaiLab = diemBaiLab;
		in >> diemKiemTra; x.diemKiemTra = diemKiemTra;
		diemGiuaKi = diemChuyenCan + diemBaiLab + diemKiemTra; x.diemGiuaKi = diemGiuaKi;
		InsertTail_DTB(list, x);
	}
	in.close();
}
//=================================================================
void TieuDe()
{
	cout << "\n=========================================================\n";
	cout << setiosflags(ios::left);
	cout << setw(10) << "Ma SV"
		<< setw(15) << "Ho"
		<< setw(15) << "Ten"
		<< setw(10) << "Nam Sinh"
		<< setw(20) << "Diem GK";
	cout << "\n=========================================================";
}
void XuatBangDiem(LISTLLSV llsv, LISTDTB dtb)
{
	TieuDe();
	NODELLSV *p = llsv.pHead;
	NODEDTB *q = dtb.pHead;
	while (p != NULL && q != NULL)
	{
		cout << endl;
		cout << setiosflags(ios::left)
			<< setw(10) << p->info.maSV
			<< setw(15) << p->info.ho
			<< setw(15) << p->info.ten
			<< setw(10) << p->info.namSinh
			<< setw(15) << setprecision(2) << setiosflags(ios::fixed) << q->info.diemGiuaKi;
		p = p->pNext;
		q = q->pNext;
	}
	cout << "\n=========================================================\
n";
}