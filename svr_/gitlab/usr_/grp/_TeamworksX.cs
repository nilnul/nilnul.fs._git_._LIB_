using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp
{
	static public class _TeamworksX
	{
		


		static public string Url_0grpId_1token(
			nilnul.web._url._query._entry.Term nsId
			,
			nilnul.web._url._query._entry.Term privateToken
		) {
			return  $"{usr._TeamworksX.SPEAR}?private_token={privateToken}&namespace_id={nsId}";
		}

		static public string Url_0grpId_1token(int grpId, string privateToken) {
			return  Url_0grpId_1token(
				new web._url._query._entry.Term(grpId.ToString())
				,
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
