using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.prj
{
	public class Url
	{

		public static  string Get(string account, string prj,string area,string version)
		{
			return vs.url_.WithPrj.GenUrlWithPrj(account, prj, area,version);
			//return _vs.url_.WithPrj.GenerateUrl1_0(account, prj, area);
		
		}

	}
}
