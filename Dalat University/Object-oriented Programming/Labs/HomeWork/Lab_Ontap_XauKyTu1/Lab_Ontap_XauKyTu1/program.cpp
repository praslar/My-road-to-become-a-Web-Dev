#include<iostream>
#include<conio.h>
using namespace std;
#include "Common.h"
#include "Thuvien.h"
#include "Menu.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 0;
}
void ChayChuongTrinh()
{
	int menu, soMenu = 10;
	String a, b;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu,a,b);
	} while (menu > 0);
}
