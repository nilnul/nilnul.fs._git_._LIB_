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
		static public string _Url_0prjId_1grpId_2token(
			string prjId
			,
			nilnul.web._url._query._entry.Term nsId
			,
			nilnul.web._url._query._entry.Term privateToken
		) {
			return  $"{usr._TeamworksX.SPEAR}/{prjId}?private_token={privateToken}&namespace_id={nsId}";
		}

		static public string _Url_0prjId_1grpId_2token(string prjId,int grpId, string privateToken) {
			return  _Url_0prjId_1grpId_2token(
				prjId
				,
				new web._url._query._entry.Term(grpId.ToString())
				,
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
