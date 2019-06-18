void KeNgangDon()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 104; i++)
	{
		cout << KENGANGDON;
	}
	cout << '|';
}
void KeNgangDoi()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 104; i++)
	{
		cout << KENGANGDOI;
	}
	cout << '|';
}
void HeadLine()
{
	KeNgangDoi();
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(9) << "Code"
		<< '|'
		<< setw(8) << "F_Name"
		<< '|'
		<< setw(15) << "M_Name"
		<< '|'
		<< setw(8) << "L_Name"
		<< '|'
		<< setw(11) << "Birthday(dd/mm/yy)"
		<< '|'
		<< setw(20) << "Address"
		<< '|'
		<< setw(20) << "Salary"
		<< '|';
	KeNgangDoi();
}
void Read_File_Array(char *filename,String a, int &n)
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "Warning! Cannot open the file!";
		_getch();
		return;
	}
	in >> n;
	for (int i = 0; i < n; i++)
	{
		in >> a[i];
	}
	in.close();
}
void Write_File_Array(char *filename, String a, int n)
{
	ofstream out(filename);
	if (!out)
	{
		cout << endl << "Cannot open the file!";
		_getch();
		return;
	}
	out << n;
	out << endl;
	for (int i = 0; i < n; i++)
	{
		out << a[i];
		out << TAB;
	}
	cout << endl << "Done!";
	out.close();
}
void Read_File_Matrix(char *filename, Matrix b, int &n)
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "Cannot open the file!";
		_getch();
		return;
	}
	in >> n;
	int i, j;
	for ( i = 0; i < n; i++)
		for (j = 0; j < n; j++)
			in >> b[i][j];
	in.close();
}
void Input_Matrix(Matrix b, int n)
{
	int i, j;
	for ( i = 0; i < n; i++)
		for ( j = 0; j < n; j++)
		{
			cout << endl << "b[" << i << "][" << j << "]= ";
			cin >> b[i][j];
		}
}
void Write_File_Matrix(char *filename, Matrix b, int n)
{
	ofstream out(filename);
	if (!out)
	{
		cout << endl << "Cannot open the file!";
		_getch();
		return;
	}
	out << n;
	int i, j;
	for ( i = 0; i < n; i++)
		{
			out << endl;
			for (j = 0; j < n; j++)
				out << b[i][j] << TAB;
		}
	out.close();
	cout << endl << "Done!";
}
int Read_File_Staff(char *filename, employees staff[MAX])
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "FILE ERROR!";
		_getch();
		return 1;
	}
	unsigned int code;
	char firstname[10];
	char middlename[15];
	char name[12];
	unsigned short int day;
	unsigned short int month;
	unsigned short int year;
	char address[20];
	unsigned salary;
	int i = 0;
	in >> code; staff[i].code = code;
	in >> firstname; strcpy_s(staff[i].firstname, firstname);
	in >> middlename; strcpy_s(staff[i].middlename, middlename);
	in >> name; strcpy_s(staff[i].name, name);
	in >> day; staff[i].birth.day = day;
	in >> month; staff[i].birth.month = month;
	in >> year; staff[i].birth.year = year;
	in >> address; strcpy_s(staff[i].address, address);
	in >> salary; staff[i].salary = salary;
	i++;
	while (!in.eof())
	{
		in >> code; staff[i].code = code ;
		in >> firstname; strcpy_s(staff[i].firstname, firstname);
		in >> middlename; strcpy_s( staff[i].middlename, middlename);
		in >> name; strcpy_s(staff[i].name, name);
		in >> day; staff[i].birth.day = day ;
		in >> month; staff[i].birth.month = month;
		in >> year; staff[i].birth.year = year;
		in >> address; strcpy_s(staff[i].address, address);
		in >> salary; staff[i].salary = salary;
		i++;
	}
	in.close();
	return i;
}
void Output_1_Staff(employees staff)
{
	cout << endl << setiosflags(ios::left)
		<< '|'
		<< setw(9) << staff.code
		<< '|'
		<< setw(8) << staff.firstname
		<< '|'
		<< setw(15) << staff.middlename
		<< '|'
		<< setw(8) << staff.name
		<< '|'
		<< setw(2) << staff.birth.day
		<< '/'
		<< setw(2) << staff.birth.month
		<< '/'
		<< setw(12) << staff.birth.year
		<< '|'
		<< setw(20) << staff.address
		<< '|'
		<< setiosflags(ios::fixed) << setprecision(0) << setw(20) << staff.salary
		<< '|';
}
void Output_All_Staff(employees staff[MAX], int n)
{
	HeadLine();
	int i;
	for ( i = 0; i < n; i++)
	{
		Output_1_Staff(staff[i]);
		if ((i + 1) % 3 == 0)
			KeNgangDon();
	}
	KeNgangDoi();
}
void Write_File_keyStaff(char *filename, employees keyStaff[MAX], int n)
{
	ofstream out(filename);
	if (!out)
	{
		cout << endl << "FILE ERROR!";
		_getch();
		return;
	}
	for (int i = 0; i < n; i++)
	{
		out << endl 
			<< SPACE << keyStaff[i].code
			<< SPACE << keyStaff[i].firstname
			<< SPACE << keyStaff[i].middlename
			<< SPACE << keyStaff[i].name
			<< SPACE << keyStaff[i].birth.day
			<< SPACE << keyStaff[i].birth.month
			<< SPACE << keyStaff[i].birth.year
			<< SPACE << keyStaff[i].address
			<< SPACE << setiosflags(ios::fixed) << setprecision(0) << keyStaff[i].salary;
	}
	out.close();
}