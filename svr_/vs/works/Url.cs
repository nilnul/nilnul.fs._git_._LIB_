using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.work
{
	public class Url
	{

		public static  string Gen(string account,string workTypeName,string version)
		{
			return nilnul.dev.git.svr_.vs.Url.GenerateUrl(account,  $"wit/workitems/${workTypeName}",version);
		
		}
		public static  string Gen_v10(string account, string workTypeName)
		{
			return Gen(account,workTypeName,nilnul.dev.git.svr_.vs._url.Ver.v10);
		
		}



	}
}
