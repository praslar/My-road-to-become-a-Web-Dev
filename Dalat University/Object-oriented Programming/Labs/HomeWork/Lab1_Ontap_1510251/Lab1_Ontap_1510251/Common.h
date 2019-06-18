#define MAX 100
typedef char String[MAX];
//=======================================================
struct nhanvien
{
	char maNV[8];
	char hoNV[10];
	char tenLot[10];
	char ten[10];
	char diachi[12];
	int namSinh;
	double luong;
};
nhanvien ds[MAX];
int n;