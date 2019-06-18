#include<iostream>
#include<conio.h>
#include<string.h>
#include<iomanip>
#include<fstream>
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
	int menu, soMenu = 21;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu);
	} while (menu>0);
}