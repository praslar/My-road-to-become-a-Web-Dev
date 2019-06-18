#include<iostream>
#include<fstream>
#include<conio.h>
#define MAX 100
#define TAB '\t'
using namespace std;
void File_Array1(char *filename, int arr[MAX], int &n);
int main()
{
	int n, arr[MAX];
	char filename[10];
	cout << endl << "Nhap ten file mo de doc: ";
	cin >> filename;
	File_Array1(filename, arr, n);
	cout << endl << "N= " << n;
	cout << endl;
	for (int i = 0; i < n; i++)
		cout << arr[i] << TAB;
	_getch();
	return 0;
}
//Mo de doc
void File_Array1(char *filename, int arr[MAX], int &n)
{
	ifstream in(filename);
	if(!in)
	{
		cout << endl << "System error";
		_getch();
		exit(1);
	}
	n = 0;
	in >> arr[n];
	while (!in.eof())
	{
		n++;
		in >> arr[n];
	}
	n++;
	in.close();
}