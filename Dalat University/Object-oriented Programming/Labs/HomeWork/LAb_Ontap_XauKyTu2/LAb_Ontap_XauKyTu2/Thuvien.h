void gets_s_NhapChuoi(String a, char kt)
{
	cout << endl << "Nhap chuoi " << kt << " : ";
	flushall();
	gets_s(a, MAX);
}
void XuatChuoi(String a)
{
	cout  << a;
}
void Noi_ChuoiSau_VaoSau_ChuoiTruoc(String a, String b)
{
	int l = strlen(a);//tinh chieu dai mang
	for (int i = 0; b[i] != NULL; i++)
		a[l++] = b[i];
	a[l] = NULL;
}
void Chep_ChuoiSau_Qua_ChuoiTruoc(String a, String b)
{
	for (int i = 0; i < (a[i]=b[i]) != NULL; i++);
}
int SoSanhChuoi()
