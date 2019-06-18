#define KENGANGDON '-'
#define KENGANGDOI '='
#define TAB '\t'
#define MAX 20
//========================================
struct LLSinhVien
{
	char maSV[8];
	char ho[15];
	char ten[15];
	unsigned short int namSinh;
	char nguyenQuan[20];
};
struct tagNodeLL
{
	LLSinhVien info;
	tagNodeLL *pNext;
};
typedef tagNodeLL NODELL;
struct LISTLL
{
	NODELL *pHead;
	NODELL *pTail;
};
//=======================================
struct DiemTK
{
	char maSV[8];
	double diemCC;
	double diemBL;
	double diemKT;
	double dgk;
};
struct tagNodeDiem
{
	DiemTK info;
	tagNodeDiem *pNext;
};
typedef tagNodeDiem NODEBD;
struct LISTBD
{
	NODEBD *pHead;
	NODEBD *pTail;
};
//=================================
LISTBD bd;
LISTLL ll;