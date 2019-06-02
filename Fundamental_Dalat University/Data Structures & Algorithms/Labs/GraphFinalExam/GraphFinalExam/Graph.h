
#pragma once	
//Thao tác trên đỉnh
//1. Tạo *
VerTex CreateVertex(LabelType label)
{
	VerTex verTex;
	verTex.label = label;
	verTex.visited = NO;
	return verTex;
}
//1.2 Thêm đỉnh vào đồ thị *
void AddVertex(Graph& graph, LabelType label)
{
	VerTex v = CreateVertex(label);
	graph.Vertices[graph.numVertices] = v;
	graph.numVertices++;
	graph.cost[graph.numVertices - 1][graph.numVertices - 1] = 0;
	for (int i = 0; i < graph.numVertices-1; i++)
	{
		graph.cost[i][graph.numVertices - 1] = INF;
		graph.cost[graph.numVertices - 1][i] = INF;
	}
}
//4. Hiển thị tên đỉnh *
void DisplayVertex(Graph graph, int pos)
{
	cout << graph.Vertices[pos].label << "\t";
}
//Khởi tạo đồ thị*
Graph InitGraph(bool directed)
{
	Graph graph;
	graph.numEdges = 0;
	graph.numVertices = 0;
	graph.directed = directed;
	for (int i = 0; i < graph.numVertices; i++)
	{
		for (int j = 0; j < graph.numVertices; j++)
		{
			if (i == j)
				graph.cost[i][j] = 0;
			else
				graph.cost[i][j] = INF;
		}
	}
	return graph;
}
// Khởi động lại trạng thái đồ thị *
void ResetFlags(Graph& graph)
{
	for (int i = 0; i < graph.numVertices; i++)
	{
		graph.Vertices[i].visited = NO;
	}
}
// Kiểm tra 2 đỉnh có nối với nhau không? *
int IsConnected(Graph graph, int start, int end)
{
	if (graph.cost[start][end] == 0 || graph.cost[start][end] == INF)
		return 0;
	return 1;
}

//===================================Học thuộc========================//
//Thêm cạnh vào đồ thị
void AddEdge(Graph& g, int start, int end, CostType w, bool directed)
{
	if (IsConnected(g,start, end) == 0)
	{
		g.numEdges++;
		g.cost[start][end] = w;
		if (!directed)
			g.cost[end][start] = w;
	}
}
void AddEdge(Graph& g, int start, int end, CostType w)
{
	AddEdge(g, start, end, w, g.directed);
}
//OpenGraph
void OpenGraph(Graph& g, char *filename)
{
	ifstream open(filename);
	if (open.is_open())
	{
		int numVers, numEdgs, weight;
		bool directed = false;
		LabelType label;
	
		open >> numVers;
		open >> numEdgs;
		open >> directed;	
		g = InitGraph(directed);

		g.numEdges = numEdgs;
		for (int i = 0; i < numVers; i++)
		{
			open >> label;
			AddVertex(g, label);
		}
		for (int i = 0; i < numVers; i++)
			for (int j = 0; j < numVers; j++)
			{
				open >> weight;
				if (weight != 0)
				{
					g.cost[i][j] = weight;
				}
			}
		open.close();
		cout << "Doc du lieu thanh cong! " << endl;
	}
	else
	{
		cout << "Loi doc du lieu" << endl;
	}
	
}
//DisplayMatrix
void DisplayMatrix(Graph g)
{
	for (int i = 0; i < g.numVertices; i++)
	{
		cout << '\t' << g.Vertices[i].label;
	}
	cout << endl << endl;
	for (int i = 0; i < g.numVertices; i++)
	{
		cout << g.Vertices[i].label << '\t';
		for (int j = 0; j < g.numVertices; j++)
		{
			if (g.cost[i][j] == 1000)
			{
				cout << "INF" << '\t';
			}
			else
			{
				cout << g.cost[i][j] << '\t';
			}
		}
		cout << endl << endl;
	}
}
//SaveGraph
void SaveGraph(Graph& g, char* filename)
{
	ofstream save(filename);
	save << g.numVertices << '\n';
	save << g.numEdges << '\n';
	save << g.directed << '\n';
	for (int i = 0; i < g.numVertices; i++)
	{
		save << g.Vertices[i].label << '\t';
	}
	save << '\n';
	for (int i = 0; i < g.numVertices; i++)
	{
		for (int j = 0; j < g.numVertices; j++)
		{
			if (g.cost[i][j] == 1000)
			{
				g.cost[i][j] = 0;
			}
			save << g.cost[i][j] << '\t';
		}
		save << '\n';
	}
}
//FindIndexVertex
int FindIndexVertex(Graph g, LabelType label)
{
	for (int i = 0; i < MAX; i++)
	{
		if (g.Vertices[i].label == label)
		{
			return i;
		}
	}
	return NULLDATA;
}
//Display Vertex Info
void DisplayInfoVertex(Graph g, int pos)
{
	cout << "Cac dinh ke voi dinh " << g.Vertices[pos].label << "la: " << endl;
	for (int i = 0; i < g.numVertices; i++)
	{
		if (g.cost[pos][i] != ZERO && g.cost[pos][i] != INF)
		{
			cout << g.Vertices[i].label << '\t';
		}
	}
}







// //=================================Main===============================//
// //Tim dinh ke voi curr ma chua xet
// int FindNeededVertex(Graph g, int curr)
// {
// 	for (int i = 0; i < g.numVertices; i++)
// 		if (g.Vertices[i].visited == NO && IsConnected(g, curr, i) == 1)
// 			return i;
// 		return NULLDATA;
// 	}
// //Duyet theo chieu rong (Breadth First Search)
// 	void BFS(Graph g, int start)
// 	{
// 		ResetFlags(g);
// 		g.Vertices[start].visited = YES;
// 		queue<int>q;
// 		q.push(start);
// 		int current, adj;
// 		while (!q.empty())
// 		{
// 			current = q.front();
// 			q.pop();
// 			DisplayVertex(g, current);
// 			while (true)
// 			{
// 				adj = FindNeededVertex(g, current);
// 				if (adj == NULLDATA)
// 				{
// 					break;
// 				}
// 				else
// 				{
// 					g.Vertices[adj].visited = YES;
// 					q.push(adj);
// 				}
// 			}
// 		}
// 	}
// //Duyet theo chieu sau (Depth First Search)
// 	void DFS_Recursion(Graph& g, int start)
// 	{
// 		g.Vertices[start].visited = YES;
// 		DisplayVertex(g, start);
// 		while (true)
// 		{
// 			int t = FindNeededVertex(g, start);
// 			if (t == NULLDATA)
// 				break;
// 			else
// 				DFS_Recursion(g, t);
// 		}
// 	}