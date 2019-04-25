using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table CAUHOI
public class CAUHOI{
public int IDCAUHOI {get; set;} 
public int IDCHUONGHOC {get; set;} 
public int IDLOAICAUHOI {get; set;} 
public string NOIDUNGCAUHOI {get; set;} 
public string GIAITHICHCAUHOI {get; set;} 
public DateTime THOIGIANUPLEN {get; set;} 
public DateTime THOIGIANSUA {get; set;} 
public string MUCDOKHO {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public CAUHOI (){}
public CAUHOI (int IDCAUHOI,int IDCHUONGHOC,int IDLOAICAUHOI,string NOIDUNGCAUHOI,string GIAITHICHCAUHOI,DateTime THOIGIANUPLEN,DateTime THOIGIANSUA,string MUCDOKHO ) 
	{
		this.IDCAUHOI = IDCAUHOI;
		this.IDCHUONGHOC = IDCHUONGHOC;
		this.IDLOAICAUHOI = IDLOAICAUHOI;
		this.NOIDUNGCAUHOI = NOIDUNGCAUHOI;
		this.GIAITHICHCAUHOI = GIAITHICHCAUHOI;
		this.THOIGIANUPLEN = THOIGIANUPLEN;
		this.THOIGIANSUA = THOIGIANSUA;
		this.MUCDOKHO = MUCDOKHO;
	}

public CAUHOI (int IDCHUONGHOC,int IDLOAICAUHOI,string NOIDUNGCAUHOI,string GIAITHICHCAUHOI,DateTime THOIGIANUPLEN,DateTime THOIGIANSUA,string MUCDOKHO ) 
	{
		this.IDCHUONGHOC = IDCHUONGHOC;
		this.IDLOAICAUHOI = IDLOAICAUHOI;
		this.NOIDUNGCAUHOI = NOIDUNGCAUHOI;
		this.GIAITHICHCAUHOI = GIAITHICHCAUHOI;
		this.THOIGIANUPLEN = THOIGIANUPLEN;
		this.THOIGIANSUA = THOIGIANSUA;
		this.MUCDOKHO = MUCDOKHO;
	}
   }
}
