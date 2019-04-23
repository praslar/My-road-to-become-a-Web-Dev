using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table CAUTRALOI
public class CAUTRALOI{
public int IDCAUTL {get; set;} 
public int IDCAUHOI {get; set;} 
public string NOIDUNGCAUTL {get; set;} 
public bool DUNGSAI {get; set;} 
public int INDEXCTL {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public CAUTRALOI (){}
public CAUTRALOI (int IDCAUTL,int IDCAUHOI,string NOIDUNGCAUTL,bool DUNGSAI,int INDEXCTL ) 
	{
		this.IDCAUTL = IDCAUTL;
		this.IDCAUHOI = IDCAUHOI;
		this.NOIDUNGCAUTL = NOIDUNGCAUTL;
		this.DUNGSAI = DUNGSAI;
		this.INDEXCTL = INDEXCTL;
	}

public CAUTRALOI (int IDCAUHOI,string NOIDUNGCAUTL,bool DUNGSAI,int INDEXCTL ) 
	{
		this.IDCAUHOI = IDCAUHOI;
		this.NOIDUNGCAUTL = NOIDUNGCAUTL;
		this.DUNGSAI = DUNGSAI;
		this.INDEXCTL = INDEXCTL;
	}
   }
}
