using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table LOAICAUHOI
public class LOAICAUHOI{
public int IDLOAICAUHOI {get; set;} 
public string TENLOAICAUHOI {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public LOAICAUHOI (){}
public LOAICAUHOI (int IDLOAICAUHOI,string TENLOAICAUHOI ) 
	{
		this.IDLOAICAUHOI = IDLOAICAUHOI;
		this.TENLOAICAUHOI = TENLOAICAUHOI;
	}

public LOAICAUHOI (string TENLOAICAUHOI ) 
	{
		this.TENLOAICAUHOI = TENLOAICAUHOI;
	}
   }
}
