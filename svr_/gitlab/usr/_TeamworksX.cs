using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr
{
	public interface ITeamwork
		:fs.git.svr.usr.ITeamwork
		,
		fs.git.svr_.gitlab.usr.repo.IMgt
	{ }
	static public class _TeamworksX
	{

		/// <summary>
		/// gitlab might have removed this.
		/// </summary>
		[Obsolete("410-Gone")]
		public const string ADDRESS = "https://gitlab.com/api/v3/projects";


		public const string SPEAR = "https://gitlab.com/api/v4/projects";
		public const string SHIELD = SPEAR+"/";


		/// <summary>
		/// token in query;
		/// </summary>
		/// <param name="privateToken"></param>
		/// <returns></returns>
		static public string Address(
			nilnul.web._url._query._entry.Term privateToken
		) {
			return  $"{SPEAR}?private_token={privateToken}";
		}

		/// <summary>
		/// token in query;
		/// </summary>
		/// <param name="privateToken">
		/// if this is a password, which contains characters such as '#','@' that URL doesnot accept for some component, an exception would be thrown.
		/// To accommodate such special character, use http request header. <see cref=""/>
		/// </param>
		/// <returns></returns>
		static public string _Address_assumeNormal( string privateToken) {
			return  Address(
				new nilnul.web._url._query._entry.Term(privateToken)

			);
		}


	}
}
