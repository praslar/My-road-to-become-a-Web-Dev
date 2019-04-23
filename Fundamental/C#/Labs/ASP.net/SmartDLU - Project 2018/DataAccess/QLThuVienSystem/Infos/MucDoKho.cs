using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess

{
//Table MUCDOKHO
public class MUCDOKHO{
public int IDMUCDOKHO {get; set;} 
public string TENMUCDOKHO {get; set;} 
public string MOTAMUCDOKHO {get; set;} 

//Phương thức có ID phục vụ cho việc Update
public MUCDOKHO (){}
public MUCDOKHO (int IDMUCDOKHO,string TENMUCDOKHO,string MOTAMUCDOKHO ) 
	{
		this.IDMUCDOKHO = IDMUCDOKHO;
		this.TENMUCDOKHO = TENMUCDOKHO;
		this.MOTAMUCDOKHO = MOTAMUCDOKHO;
	}

public MUCDOKHO (string TENMUCDOKHO,string MOTAMUCDOKHO ) 
	{
		this.TENMUCDOKHO = TENMUCDOKHO;
		this.MOTAMUCDOKHO = MOTAMUCDOKHO;
	}
   }
}
