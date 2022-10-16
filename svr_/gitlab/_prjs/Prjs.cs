using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.svr_.gitlab
{
	[Obsolete()]
	static public class _PrjsX
	{
		public const string ADDRESS = "https://gitlab.com/api/v3/projects";
		static public string Address(string privateToken) {
			return  Address(
				new nilnul.web._url._query._entry.Term(privateToken)
			);
		}

		static public string Address(nilnul.web._url._query._entry.Term privateToken) {
			return  $"{ADDRESS}?private_token={privateToken}";
		}
	}
}
