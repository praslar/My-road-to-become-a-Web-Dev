#include<iostream>
#include<conio.h>
#include<fstream>
#include<iomanip>
using namespace std;
#include"Common.h"
#include"Thuvien.h"
#include"Menu.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 1;
}
void ChayChuongTrinh()
{
	int menu, soMenu = 3;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu);
	} while (menu > 0);
}