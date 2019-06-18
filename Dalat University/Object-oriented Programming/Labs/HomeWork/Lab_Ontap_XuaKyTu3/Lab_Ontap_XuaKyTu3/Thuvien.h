char Chuyen_KT_Thuong(char x)
{
	if ('A' <= x && x <= 'Z')
		x = x + 32;
	return x;
}
char Chuyen_KT_Hoa(char x)
{
	if ('a' <= x && x <= 'z')
		x = x - 32;
	return x;
}
void ChenCuoi(String b, char kt)
{
	int i;
	for (i = 0; b[i] != NULL; i++);
	b[i++] = kt;
	b[i] = NULL;
}
void NanTen(char a[MAX])
{
	int i;
	char b[MAX];//Xau trung gian
	b[0] = NULL;
	i = 0;
	//Khử dấu cách
	while (a[i] == CACH)
		i++; //a[i] == NULL hay la dau 1 tu
	while (a[i] != NULL) //xu ly tu
	{
		ChenCuoi(b, Chuyen_KT_Hoa(a[i])); // xu ly dau tu: a[i]
		i++; //xet ky tu ke tiep : than tu, CACH hay ket thuc xau
		while (a[i] != CACH && a[i] != NULL) //ky tu trong than tu
		{
			ChenCuoi(b, Chuyen_KT_Thuong(a[i])); // xu ly than tu
			i++;
		} //a[i] == CACH hay a[i] == NULL
		  //Da xu ly xong 1 tu
		  //Chua ket thuc xau thi tiep tuc xu ly tu tiep theo
		  //Tiep tuc vuot dau cach
		while (a[i] == CACH)
			i++; //a[i] == NULL hay la dau 1 tu
		if (a[i] != NULL) //tu vua xu ly chua phai la tu cuoi
			ChenCuoi(b, CACH); // chen cach vao sau b
	}
	strcpy_s(a, MAX, b);
}
