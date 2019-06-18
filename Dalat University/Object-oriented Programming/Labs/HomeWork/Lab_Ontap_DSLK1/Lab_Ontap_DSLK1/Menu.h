void XuatMenu()
{
	DoubleCross();
	cout << endl << "|                     <Functions System>";
	cout << endl << "| 0. Thoat khoi chuong trinh.";
	cout << endl << "| 1.  ";
	cout << endl << "| 2.";
	cout << endl << "| 3. ";
	cout << endl << "| 4. ";
	cout << endl << "| 5. ";
	cout << endl << "| 6. ";
	DoubleCross();
}
int ChonMenu(int soMenu)
{
	int stt;
	for (;;)
	{
		system("CLS");
		XuatMenu();
		cout << endl << "Chon menu: ";
		cin >> stt;
		if (0 <= stt && stt <= soMenu)
			break;
	}
	return stt;
}
void XuLyMenu(int menu)
{
	switch (menu)
	{
	case 0:
		system("CLS");
		cout << setiosflags(ios::right);
		cout << setw(50) << endl << "Microsoft Visual Studio" << TAB << "Pham Xuan Thang"
			<< setw(50) << endl << "Local Windows Debugger" << TAB << "CTK39B"
			<< setw(50) << endl << "Server Explorer" << TAB << "1510251"
			<< setw(50) << endl << "Toolboxes" << TAB << "21/7/2017"
			<< setw(50) << endl << "Quick Launch" << TAB << "Da Lat";
		cout << endl << endl << endl;
		cout << endl << "                                            PROJECT LINKED-LIST";
		cout << endl << "Thank you for your cooperation";
		cout << endl << "Next project: Final exam ";
		cout << endl << "Lauch date: **/8/2017" << TAB << "Time: 4:00 PM";
		cout << endl << "Remember:: Always do your best!";
		cout << endl << "                                                  THE END";
		_getch();
		break;
	case 1:
		system("CLS");
		File_List_LL("LLSV.txt", ll);
		File_List_BD("DiemGK.txt", bd);
		OutPut_BD(ll, bd);
		_getch();
		break;
	default:
		break;
	}
}
