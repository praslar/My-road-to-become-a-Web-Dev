#pragma once
void gets_s_NhapChuoi(String a, char kt)
{
	cout << endl << "Nhap chuoi: " << kt << " = ";
	int t = _flushall();
	gets_s(a, MAX);
}
void XuatChuoi(String a)
{
	cout << a;
}
int strlen_ChieuDaiChuoi(String a)
{
	int l = strlen(a);
	return l;
}
void strcat_s_Noi_ChuoiSau_VaoDuoi_ChuoiTruoc(String a, String b)
{
	strcat_s(a, MAX, b);
}
void strcpy_s_Chep_ChuoiSau_Qua_ChuoiTruoc(String a, String b)
{
	strcpy_s(a, MAX, b);
}
int _strcmpi_SoSanhChuoi_KPB(String a, String b)
{
	return _strcmpi(a, b);
}
int strcmp_SoSanhChuoi_PB(String a, String b)
{
	return strcmp(a, b);
}