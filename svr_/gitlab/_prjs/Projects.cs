using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab
{
	[Obsolete(nameof(_PrjsX))]
	public class Projects
	{
		[Obsolete("gitlab has removed this; use v4.",true)]
		public const string UrlBase_v3 = "https://gitlab.com/api/v3/projects";// seems invalid on 20170607 
		public const string UrlBase = "https://gitlab.com/projects";

		// string Get(string privateToken) {

		//	var url = $"{UrlBase}?private_token={privateToken}";

		////	throw new NotImplementedException();
		//}
	}
}
