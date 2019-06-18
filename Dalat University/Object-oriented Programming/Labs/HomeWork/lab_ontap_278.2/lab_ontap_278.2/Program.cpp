#include<iostream>
#include<conio.h>
#include<iomanip>
#include<fstream>
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
	int menu, soMenu = 5;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu);
	} while (menu>0);
}
