#define KENGANGDON '-'
#define KENGANGDOI '='
#define TAB '\t'
//=======================================================
struct Nhanvien
{
	char maNV[10];
	char ho[10];
	char tenLot[15];
	char ten[10];
	char diaChi[20];
	unsigned short int namSinh;
	double luong;
};
struct tagNode
{
	Nhanvien info;
	tagNode *pNext;
};
typedef tagNode NODELL;
struct LIST
{
	NODELL *pHead;
	NODELL *pTail;
};
//=================================
Nhanvien x;
LIST list;
int n = 0;