using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class CHUYENDOI
	{
		public static string DoiCoSo(int k)
		{
			string resutl = "";
			while (k != 0)
			{
				if (k == 1)
				{
					resutl = resutl + "A";
					k = 0;
				}
				else if (k == 2)
				{
					resutl = resutl + "B";
					k = 0;
				}
				else if (k == 3)
				{
					resutl = resutl + "C";
					k = 0;
				}
				else if (k == 4)
				{
					resutl = resutl + "D";
					k = 0;
				}
				else if(k == 5)
				{
					resutl = resutl + "E";
					k = 0;
				}
				else if(k == 6)
				{
					resutl = resutl + "F";
					k = 0;
				}
			}
			return (resutl);
		}
	}
}
