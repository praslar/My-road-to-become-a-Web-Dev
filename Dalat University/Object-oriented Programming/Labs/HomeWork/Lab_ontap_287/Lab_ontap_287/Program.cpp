#include <iostream>
#include <fstream>
#include <string.h>
#include <conio.h>
#include <iomanip>
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
	int menu, soMenu = 10;
	do
	{
		menu = ChonMenu(soMenu);
		XuLyMenu(menu);
	} while (menu > 0);
}