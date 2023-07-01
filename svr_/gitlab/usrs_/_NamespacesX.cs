using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usrs_
{
	static public class _NamespacesX
	{


		public const string SPEAR = $"{gitlab._ApiX.SHIELD}namespaces";
		public const string SHIELD = SPEAR+"/";


		/// <summary>
		/// token in query;
		/// </summary>
		/// <param name="privateToken"></param>
		/// <returns></returns>
		static public string ToUrl(
			nilnul.web._url._query._entry.Term privateToken
		)
		{
			return $"{SPEAR}?private_token={privateToken}";
		}

		/// <summary>
		/// token in query;
		/// </summary>
		/// <param name="privateToken">
		/// if this is a password, which contains characters such as '#','@' that URL doesnot accept for some component, an exception would be thrown.
		/// To accommodate such special character, use http request header. <see cref=""/>
		/// </param>
		/// <returns></returns>
		static public string ToUrl(string privateToken)
		{
			return ToUrl(
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
