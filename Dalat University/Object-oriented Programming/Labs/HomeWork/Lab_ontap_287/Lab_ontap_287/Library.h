void KeNgangDoi()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 97; i++)
	{
		cout << KENGANGDOI;
	}
	cout << '|';
}
void KeNgangDon()
{
	cout << endl << setiosflags(ios::left) << '|';
	for (int i = 0; i < 97; i++)
	{
		cout << KENGANGDON;
	}
	cout << '|';
}
void Read_File_Array(char *filename, int a[MAX], int &n)
{
	ifstream in(filename);
	if (!in)
	{
		cout << endl << "READ FILE ERROR!";
		_getch();
		return;
	}
	in >> n;
	while (!in.eof())
	{
		for (int i = 0; i < n; i++)
		{
			in >> a[i];
		}
	}
	in.close();
}
void Xuat_Array(int a[MAX], int n)
{
	int i;
	cout << endl << "So phan tu cua mang: " << n;
	cout << endl;
	for (i = 0; i < n; i++)
	{
		cout << a[i] << TAB;
	}
}
//====================================================
void HoanVi(int &a, int &b)
{
	int tam = a;
	a = b;
	b = tam;
}
void Selection_L(int a[MAX], int n)
{
	int i, j, cs_min;
	for (i = 0; i < n - 1; i++)
	{
		cs_min = i;
		for (j = i + 1; j < n; j++)
			if (a[j] < a[cs_min])
				cs_min = j;
		HoanVi(a[i], a[cs_min]);
	}
}
int Linesearch_Fisrt(int a[MAX], int n, int x)
{
	int i = 0;
	while ((i < n) && a[i] != x)
		i++;
	if (i == n)
		return -1;
	return i;
}
int Linesearch_First_(int a[MAX], int n, int x)
{
	int i = 0;
	a[n] = x;
	while (a[i] != x)
		i++;
	if (i == n)
		return -1;
	return i;
}
int Linesearch_End_(int a[MAX], int n, int x)
{
	int i = n - 1;
	a[-1] = x;
	while ((a[i] != x))
		i--;
	return i;
}
void Linesearch_All(int a[MAX], int n, int x)

{
	int i,
		Kiemtra = 0;
	for ( i = 0; i < n; i++)
		if (a[i]==x)
		{
			Kiemtra = 1;
			cout << i << TAB;
		}
	if (Kiemtra == 0)
	{
		cout << endl << x << "Khong co trong mang a!!!";
	}
}