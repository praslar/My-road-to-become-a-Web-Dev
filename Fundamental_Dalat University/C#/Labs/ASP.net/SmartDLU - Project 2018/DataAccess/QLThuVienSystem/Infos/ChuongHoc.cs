using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table CHUONGHOC
public class CHUONGHOC{
public int IDCHUONGHOC {get; set;} 
public int IDMONHOC {get; set;} 
public string TENCHUONGHOC {get; set;} 
public string MOTACHUONGHOC {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public CHUONGHOC (){}
public CHUONGHOC (int IDCHUONGHOC,int IDMONHOC,string TENCHUONGHOC,string MOTACHUONGHOC ) 
	{
		this.IDCHUONGHOC = IDCHUONGHOC;
		this.IDMONHOC = IDMONHOC;
		this.TENCHUONGHOC = TENCHUONGHOC;
		this.MOTACHUONGHOC = MOTACHUONGHOC;
	}

public CHUONGHOC (int IDMONHOC,string TENCHUONGHOC,string MOTACHUONGHOC ) 
	{
		this.IDMONHOC = IDMONHOC;
		this.TENCHUONGHOC = TENCHUONGHOC;
		this.MOTACHUONGHOC = MOTACHUONGHOC;
	}
   }
}
