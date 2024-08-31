using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp
{
	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="acc_.grp.ICollaboration"/>
	static public class _ColabX
	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prjId">
		/// int
		/// ,or,
		/// path encoded, <see href="docs.gitlab.com/ee/api/projects.html#get-single-project"/>
		/// </param>
		/// <param name="nsId"></param>
		/// <param name="privateToken"></param>
		/// <returns></returns>
		static public string _Url_0prj_1token(
			string prjId
			,
			nilnul.web._url._query._entry.Term privateToken
		) {
			return  $"{usr._TeamworksX.SPEAR}/{prjId}?private_token={privateToken}";
		}

		static public string _Url_0prj_1token(string prjId, string privateToken) {
			return  _Url_0prj_1token(
				prjId
				,
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
