#define MAX 100
#define NGANGDON '-'
#define NGANGDOI '='
struct NhanVien
{
	char maNV[8];
	char ho[10];
	char tenLot[10];
	char ten[10];
	char diaChi[15];
	unsigned int namSinh;
	double luong;
};
struct tagNodeNV
{
	NhanVien info;
	tagNodeNV *pNext;
};
typedef tagNodeNV NODENV;
struct LISTNV
{
	NODENV *pHead;
	NODENV *pTail;
};
//==========================================
NhanVien x;
LISTNV list;
int n = 0;