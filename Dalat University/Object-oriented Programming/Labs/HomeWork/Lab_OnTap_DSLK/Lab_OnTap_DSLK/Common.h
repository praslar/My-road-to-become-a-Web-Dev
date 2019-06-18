#define MAX 100
#define NGANGDOI '='
struct LyLichSinhVien
{
	char maSV[8];
	char ho[20];
	char ten[10];
	unsigned int namSinh;
	char nguyenQuan[20];
};
struct tagNodeLLSV
{
	LyLichSinhVien info;
	tagNodeLLSV *pNext;
};
typedef tagNodeLLSV NODELLSV;
struct LISTLLSV
{
	NODELLSV *pHead;
	NODELLSV *pTail;
};
//=================================
struct DiemTB
{
	char maSV[8];
	double diemChuyenCan;
	double diemBaiLab;
	double diemKiemTra;
	double diemGiuaKi;
};
struct tagNodeDTB
{
	DiemTB info;
	tagNodeDTB *pNext;
};
typedef tagNodeDTB NODEDTB;
struct LISTDTB
{
	NODEDTB *pHead;
	NODEDTB *pTail;
};
//=================================
LISTLLSV llsv;
LISTDTB dtb;
