#define NGANDOI '='
#define MAX 100
typedef unsigned short int Byte;
struct NgayThangNam
{
	Byte Ngay;
	Byte Thang;
	unsigned int Nam;
};
struct NhanVien
{
	char maNV[8];
	char ho[10];
	char tenLot[20];
	char ten[7];
	NgayThangNam ntns;
	char diaChi[21];
	double luong;
};
NhanVien a[MAX] = 
{
	{"1234507","Nguyen","Van","Tan",{1,1,1990},"Da Lat",20345678.0},
	{"1234504","Ho","Thi","Nam",{2,8,1995},"Qui Nhon",14345872.0},
	{"1234505","Nguyen","Van","Vo",{7,11,1996},"Phu Yen",2031024.0},
	{"1510251","Pham","Xuan","Thang",{11,8,1997},"Da Lat",25000000.0} 
};
NhanVien p;
int n = 4;