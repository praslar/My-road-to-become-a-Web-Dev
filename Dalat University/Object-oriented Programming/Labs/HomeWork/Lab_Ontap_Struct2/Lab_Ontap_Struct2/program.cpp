#include<iostream>
#include<conio.h>
#include<iomanip>
#include<string.h>
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
	int soMenu=9, menu;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu,a,n);
	} while (menu>0);
}