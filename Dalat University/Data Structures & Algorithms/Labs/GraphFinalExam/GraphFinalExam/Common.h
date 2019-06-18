#define UPPER	100
#define ZERO	0
#define MAX		20		//đỉnh tối đa
#define	INF		1000	//vô cùng
#define	YES		1		//đã xét
#define NO		0		//chưa xét
#define	NULLDATA -1		//giá trị rỗng

typedef char LabelType;
typedef int CostType;
typedef CostType Matrix[MAX][MAX];

//Định nghĩa 1 đỉnh
struct VerTex
{
	LabelType label;
	int visited;
};

//Cạnh
struct Edge
{
	int source;
	int target;
	CostType weight;
	int marked;
};

//Đường đi
struct Path
{
	CostType length;
	int parent;
};

//Đồ thị
struct Graph
{
	bool directed;
	int numVertices;
	int numEdges;
	Matrix cost;		  //Ma trận biểu diễn
	VerTex Vertices[MAX]; //Danh sách đỉnh
};
