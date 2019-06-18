#include<iostream>
#include<iomanip>
#include<fstream>
#include<conio.h>
#include<string.h>
using namespace std;
#include"Common.h"
#include"Library.h"
#include"Menu.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 0;
}
void ChayChuongTrinh()
{
	int soMenu=10, menu;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu);
	} while (menu > 0);
}
