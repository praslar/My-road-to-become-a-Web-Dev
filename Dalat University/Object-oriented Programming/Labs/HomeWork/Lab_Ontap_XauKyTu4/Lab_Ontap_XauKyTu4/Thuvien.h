void gets_s_NhapChuoi(String a, char kt)
{
	_flushall();
	cout << endl << "Nhap chuoi " << kt << ": ";
	gets_s(a, MAX);
}
void XuatChuoi(String a)
{
	cout << a;
}
char Chuyen_KyTu_Thuong(char x)
{
	if ('A' <= x && x <= 'Z' )
	{
		x = x + 32;
	}
	return x;
}
char Chuyen_KyTu_Hoa(char x)
{
	if ('a' <= x && x <= 'z')
	{
		x = x - 32;
	}
	return x;
}
void ChenCuoi(String b, char kt)
{
	int i;
	for (i = 0; b[i] != NULL; i++);
	b[i++] = kt;
	b[i] = NULL;
}
void NanTen(String a)
{
	int i = 0;
	String b;
	b[0] = NULL;
	while (a[i] == 0)
		i++;// Nhay dấu cách đến khi gặp ký tự đầu
	while (a[i] != NULL)//Xét từ
	{
		ChenCuoi(b, Chuyen_KyTu_Hoa(a[i]));//Chuyển ký tự đầu của từ thành HOA, lưu vào String b
		i++;//Xét các từ tiếp theo
		while (a[i] != CACH && a[i] != NULL)
		{
			ChenCuoi(b, Chuyen_KyTu_Thuong(a[i]));//Chuyển HOA thành thường
			i++;//Tiếp tục xét từ đến khi gặp dấu cách, kết thúc 1 từ
		}
		while (a[i] == CACH)// nhảy dấu cách, đến ký tự đầu từ tiếp theo
			i++;
		if (a[i] != NULL)// chèn 1 dấu cách giữa 2 từ trong mảng b 
			ChenCuoi(b, CACH);
	}
	strcpy_s(a, MAX, b);
}
int strlen_ChieuDai_Chuoi(String a)
{
	return strlen(a);
}
int TinhChieuDaiChuoi(String a)
{
	int i = 0;
	while (a[i])
	{
		i++;
	}
	return i;
}
void ChenDau_KT(String a, char x)
{
	int l = TinhChieuDaiChuoi(a);
	for (int i = l; i >= 0; i--)
	{
		a[i + 1] = a[i];
	}
	a[0] = x;
}
void ChenCuoi_KT(String a, char x)
{
	int l = TinhChieuDaiChuoi(a);
	a[l++] = x;
	a[l] = NULL;
}
int ChenKT_VT(String a, char x, int vt)
{
	int i, l, kq = 1;
	l = TinhChieuDaiChuoi(a);
	if (vt == 0)
	{
		ChenDau_KT(a,x);
	}
	else
	{
		if (vt == l)
		{
			ChenCuoi(a, x);
		}
		else
			if (0 < vt && vt < l)
			{
				for  (i = l; i >= vt; i--)
				{
					a[i + 1] = a[i];
				}
				a[vt] = x;
			}
			else kq = 0;
	}
	return kq;
}
void XoaDau_KT(String a)
{
	int i;
	for ( i = 0; a[i] != NULL; i++)
		a[i] = a[i + 1];
	a[i - 1] = NULL;
}
void XoaCuoi_KT(String a)
{
	int l = TinhChieuDaiChuoi(a);
	a[l - 1] = NULL;
}
int XoaKT_VT(String a, int vt)
{
	int i, l, kq = 1;
	l = TinhChieuDaiChuoi(a);
	if (vt == 0)
		XoaDau_KT(a);
	else
	{
		if (vt == l)
			XoaCuoi_KT(a);
		else
		{
			if (0 < vt && vt < l-1)
			{
				for ( i = l-1; i > vt; i--)
				{
					a[i - 1] = a[i];
				}
				a[l - 1] = NULL;
			}
			else
				kq = 0;
		}
	}
	return kq;
}
void CatDauChenCuoi(String a)
{
	int i, l = TinhChieuDaiChuoi(a);
	char x;
	x = a[0];
	for (i = 1; a[i] != NULL; i++)
		a[i - 1] = a[i];
	a[l - 1] = x;
}
void CatCuoiChenDau(String a)
{
	int i, l = TinhChieuDaiChuoi(a);
	char x;
	x = a[l-1];
	for (i = l-2; i >= 0; i--)
		a[i+1] = a[i];
	a[0] = x;
}
void Xoa_x(String a, char x)
{
	int i, h = 0;
	for (i = 0; a[i] != NULL; i++)
		if (a[i] != x)
			a[h++] = a[i];
	a[h] = NULL;
}
void Thay_x_Bang_y(String a, char x, char y)
{
	int i;
	for (i = 0; a[i] != NULL; i++)
	{
		if (a[i] == x)
			a[i] = y;
	}
}