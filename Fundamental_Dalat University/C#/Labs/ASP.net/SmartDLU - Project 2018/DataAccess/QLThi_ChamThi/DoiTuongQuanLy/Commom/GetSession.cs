using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccess
{
	public class GetSession
	{
		public static string ID { get; set; }
		public static int IDDETHI { get; set; }
		public static int IDLICHTHI { get; set; }
		public static int IDDIEMTHI { get; set; }
		public static string THOIGIANCONLAI { get; set; }

		public GetSession()
		{
			try
			{
				ID = (string)HttpContext.Current.Session[UserSession.ID];
				IDDETHI = (int)HttpContext.Current.Session[UserSession.IDDETHI];
				IDLICHTHI = (int)HttpContext.Current.Session[UserSession.IDLICHTHI];
				IDDIEMTHI = (int)HttpContext.Current.Session[UserSession.IDDIEMTHI];
				THOIGIANCONLAI = (string)HttpContext.Current.Session[UserSession.THOIGIANCONLAI];

			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
