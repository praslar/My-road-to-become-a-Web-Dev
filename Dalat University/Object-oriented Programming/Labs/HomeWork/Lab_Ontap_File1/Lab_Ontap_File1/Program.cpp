#include<iostream>
#include<conio.h>
#include<string.h>
#include<fstream>
#include<iomanip>
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
	int menu, soMenu = 6;
	int n;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu, a, b,n);
	} while (menu >0);
}