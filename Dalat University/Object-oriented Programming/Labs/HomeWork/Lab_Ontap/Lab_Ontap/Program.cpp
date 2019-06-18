#include <iostream>
#include <iomanip>
#include <conio.h>
#include <string.h>
#include <fstream>
using namespace std;
#include "Common.h"
#include "Library.h"
#include "Menu.h"
void ChayChuongTrinh();
int main()
{
	ChayChuongTrinh();
	return 1;
}
void ChayChuongTrinh()
{
	int soMenu = 5, menu;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu,n);
	} while (menu>0);
}