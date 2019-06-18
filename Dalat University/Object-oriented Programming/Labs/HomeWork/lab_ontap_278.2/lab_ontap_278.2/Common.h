#define KENGANGDON '-'
#define	KENGANGDOI '='
#define TAB '\t'
#define MAX 20
//====================================
struct Nhanvien
{
	char maNV[10];
	char ho[10];
	char tenLot[15];
	char ten[10];
	unsigned short int namSinh;
	double luong;
};
//=====================================
Nhanvien danhsach[MAX];
int n;