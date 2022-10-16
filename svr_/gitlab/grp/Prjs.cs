using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.grp
{
	static public class _PrjsX
	{
		/// <summary>
		/// gitlab might have removed this.
		/// </summary>
		[Obsolete("410-Gone")]
		public const string ADDRESS = "https://gitlab.com/api/v3/projects";
		public const string SPEAR4V = "https://gitlab.com/api/v4/projects";
		public const string SHIELD4V = SPEAR4V+"/";


		static public string Address(
			nilnul.web._url._query._entry.Term nsId
			,
			nilnul.web._url._query._entry.Term privateToken
		) {
			return  $"{SPEAR4V}?private_token={privateToken}&namespace_id={nsId}";
		}

		static public string _Address_assumesNormal(string grpId, string privateToken) {
			return  Address(
				new web._url._query._entry.Term(grpId)
				,
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
