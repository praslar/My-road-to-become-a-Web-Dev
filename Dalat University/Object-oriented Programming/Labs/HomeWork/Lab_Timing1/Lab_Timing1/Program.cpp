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
	return 1;
}
void ChayChuongTrinh()
{
	int menu, soMenu = 2;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu);
	} while (menu>0);
}