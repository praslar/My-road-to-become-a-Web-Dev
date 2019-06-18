#include<iostream>
#include<conio.h>
#include<string.h>
#include<fstream>
#include<iomanip>
using namespace std;
#include"Common.h"
#include"Thuvien.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 0;
}
void ChayChuongTrinh()
{
	File_List_LLSV("LLSV.txt", llsv);
	File_List_DTB("DiemGK.txt", dtb);
	XuatBangDiem(llsv, dtb);
	cout << endl;
	_getch();
}