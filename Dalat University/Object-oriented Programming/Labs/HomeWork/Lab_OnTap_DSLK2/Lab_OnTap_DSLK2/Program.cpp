#include<iostream>
#include<conio.h>
#include<string.h>
#include<iomanip>
#include<fstream>
using namespace std;
#include"Common.h"
#include"Thuvien.h"
#include"Menu.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 0;
}
void ChayChuongTrinh()
{
	int menu,soMenu = 5;
	
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu,x,list);
	} while (menu > 0);
}