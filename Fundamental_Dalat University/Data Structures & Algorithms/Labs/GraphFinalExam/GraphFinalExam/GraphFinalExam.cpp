// GraphFinalExam.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <conio.h>
#include <stack>
#include <queue>
#include <fstream>

using namespace std;

#include "Common.h"
#include "Graph.h"

int main()
{
	Graph g;
	char filename[10] = "Text.txt";
	char save[11] = "Output.txt";

	char VertexU;
	char VertexV;
	int VertexPosition1;
	int VertexPosition2;
	int weight;

	cout << "Pham Xuan Thang" << endl << "CTK39" << endl << "1510251" << endl;
	cout << "=========================Data Structe & Algorithm============================== " << endl;
	cout << "Cau 1: Doc do thi tu file: " << endl;
	OpenGraph(g, filename);
	cout << "Hien thi do thi: " << endl;
	DisplayMatrix(g);
	cout << "Cau 2: Hien thi thong tin cua dinh: " << endl;
	do
	{
		cout << "Nhap dinh can hien thi thong tin: ";
		cin >> VertexU;
		VertexPosition1 = FindIndexVertex(g, VertexU);
	} while (VertexPosition1 == NULLDATA);
	cout << endl;
	DisplayInfoVertex(g, VertexPosition1);
	cout << endl;
	cout << "Cau 3: Them canh giua hai dinh u,v co trong so w vao do thi: " << endl;
	do
	{
		cout << "Nhap dinh U: ";
		cin >> VertexU;
		VertexPosition1 = FindIndexVertex(g, VertexU);
	} while (VertexPosition1 == NULLDATA);
	cout << endl;
	do
	{
		cout << "Nhap dinh V: ";
		cin >> VertexV;
		VertexPosition2 = FindIndexVertex(g, VertexV);
	} while (VertexPosition2 == NULLDATA);
	cout << "Nhap trong so w: ";
	cin >> weight;

	AddEdge(g, VertexPosition1, VertexPosition2, weight);
	cout << endl << "Ma tran hien tai: " << endl;
	DisplayMatrix(g);
	cout << "Cau 5: Luu du lieu vao file Output.txt" << endl;
	SaveGraph(g, save);
	_getch();
}

