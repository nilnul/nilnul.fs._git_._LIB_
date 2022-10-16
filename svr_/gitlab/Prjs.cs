using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab
{
	static public class _PrjsX
	{
		public const string SPEAR = "https://gitlab.com/api/v4/projects";
		public const string SHIELD = SPEAR+"/";


		static public string Address(
			nilnul.web._url._query._entry.Term privateToken
		) {
			return  $"{SPEAR}?private_token={privateToken}";
		}

		static public string _Address_assumeNormal( string privateToken) {
			return  Address(
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
