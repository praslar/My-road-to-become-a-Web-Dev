#define MAX 100
#define KENGANGDON '-'
#define KENGANGDOI '='
#define TAB '\t'
#define SPACE ' '
typedef char String[MAX];
typedef int Matrix[MAX][MAX];
//=================================
struct date 
{
	unsigned short int day;
	unsigned short int month;
	unsigned short int year;
};
struct employees
{
	unsigned int code;
	char firstname[10];
	char middlename[15];
	char name[10];
	date birth;
	char address[20];
	unsigned salary;
};
//=================================
String a;
Matrix b;
date birth;
employees staff[MAX];
employees keyStaff[MAX] = {
	{123456,"Pham","Xuan","Pop",11,8,1997,"Da_Lat",20000000},
	{ 123459,"Pham","Xuan","Vip",11,8,1997,"Da_Lat",30000000 },
	{ 123457,"Pham","Xuan","Vl",11,8,1997,"Da_Lat",40000000 }
};