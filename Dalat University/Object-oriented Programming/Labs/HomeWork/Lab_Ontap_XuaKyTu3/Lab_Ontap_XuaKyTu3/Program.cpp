#include <iostream>
#include <conio.h>
using namespace std;
#include "common.h"
#include "thuvien.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 1;
}
void ChayChuongTrinh()
{
	String a;
	char thoat;
	do
	{
		system("CLS");
		cout << endl << "Nhap xau ky tu: ";
		gets_s(a);
		_flushall();
		system("CLS");
		cout << "\nTen vua nhap: ";
		cout << a;
		NanTen(a);
		cout << "\nTen da nan : ";
		cout << a;
		cout << endl << "ESC de thoat hoac phim bat ky de tiep tuc.";
		thoat = _getch();
	} while (thoat!=27);
	_getch();
}