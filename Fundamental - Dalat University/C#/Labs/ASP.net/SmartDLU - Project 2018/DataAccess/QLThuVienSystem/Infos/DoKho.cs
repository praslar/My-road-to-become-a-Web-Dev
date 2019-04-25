using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table DOKHO
public class DOKHO{
public int IDDOKHO {get; set;} 
public int IDMUCDOKHO {get; set;} 
public string TENDOKHO {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public DOKHO (){}
public DOKHO (int IDDOKHO,int IDMUCDOKHO,string TENDOKHO ) 
	{
		this.IDDOKHO = IDDOKHO;
		this.IDMUCDOKHO = IDMUCDOKHO;
		this.TENDOKHO = TENDOKHO;
	}

public DOKHO (int IDMUCDOKHO,string TENDOKHO ) 
	{
		this.IDMUCDOKHO = IDMUCDOKHO;
		this.TENDOKHO = TENDOKHO;
	}
   }
}
