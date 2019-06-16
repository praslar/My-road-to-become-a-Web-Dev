using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table MONHOC
public class MONHOC{
public int IDMONHOC {get; set;} 
public int IDMUCDOKHO {get; set;} 
public string TENMONHOC {get; set;} 
public string MOTAMONHOC {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public MONHOC (){}
public MONHOC (int IDMONHOC,int IDMUCDOKHO,string TENMONHOC,string MOTAMONHOC ) 
	{
		this.IDMONHOC = IDMONHOC;
		this.IDMUCDOKHO = IDMUCDOKHO;
		this.TENMONHOC = TENMONHOC;
		this.MOTAMONHOC = MOTAMONHOC;
	}

public MONHOC (int IDMUCDOKHO,string TENMONHOC,string MOTAMONHOC ) 
	{
		this.IDMUCDOKHO = IDMUCDOKHO;
		this.TENMONHOC = TENMONHOC;
		this.MOTAMONHOC = MOTAMONHOC;
	}
   }
}
