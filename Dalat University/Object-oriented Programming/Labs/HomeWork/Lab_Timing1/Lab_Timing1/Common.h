#define KENGANGDON '-'
#define KENGANGDOI '='
#define TAB '\t'
#define MAX 20
//===========================
struct Namsinh
{
	unsigned short int ngay;
	unsigned short int thang;
	unsigned short int nam;
};
struct Nhanvien
{
	char maNV[8];
	char ho[12];
	char tenLot[10];
	char ten[10];
	char diaChi[15];
	Namsinh ngaythangnamsinh;
	double luong;
};
//=======================================
Nhanvien danhsach[MAX];
int soluongnhanvien;