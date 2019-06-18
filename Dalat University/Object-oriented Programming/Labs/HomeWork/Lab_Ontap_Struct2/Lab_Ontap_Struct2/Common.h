#define MAX 100
#define NGANGDOI '='
#define NGANGDON '-'
struct SinhVien
{
	char maSV[8];
	char ho[15];
	char ten[8];
	unsigned int namSinh;
	char gioiTinh[4];
	char queQuan[15];
	char lop[6];
};
struct BangDiem
{
	char maSV[8];
	double diemLab;
	double diemGK;
	double diemCK;
	double diemTK;
};
//=====================================
SinhVien a[MAX];	
BangDiem b[MAX];
int n = 0;