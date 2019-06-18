#include <iostream>
#include <conio.h>
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
	String a;
	int soMenu=12, menu;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu,a);
	} while (menu > 0);
}