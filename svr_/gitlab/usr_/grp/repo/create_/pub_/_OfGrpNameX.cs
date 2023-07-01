using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using nilnul.fs.git.svr_.gitlab.repo;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp.repo.create_.pub_
{
	static public class _OfGrpNameX
	{
		public static string ByWebReq(string grpId, Name name, string privateToken)
		{
			return _ByWebReq_1repoNameNormalized(
				grpId
				,
				name.ToString()
				,
				privateToken
			);

		}

		static public string _ByWebReq_1unnormed(
			string grp
			,
			string _prjName__normalized
			,

			string privateToken
		)
		{
			return ByWebReq(
				grp
				,
				fs.git.svr_.gitlab.repo.Name.Normalize(_prjName__normalized)
				,
				privateToken
			);

		}

		/// <summary>
		/// "." will be replaced with "-" for the dir, but not the name.
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="_prjName__normalized">must be normalized as the server will not do it automatically
		/// for creation, the name is converted by the server
		/// </param>
		/// <returns></returns>
		static public  string _ByWebReq_1repoNameNormalized(
			string grp
			,
			string _prjName__normalized
			,
			string privateToken
		)
		{
			var id = fs.git.svr_.gitlab.usr_.grp._IdX.AsId0nul(
				grp
			);

			if (id is null)
			{
				throw new grp_.xpn_.NameNonexistException($"fetch id of {grp} failed as it might be nonexistant;");
			}

			return _PublicX._ByWebReq_1repoNameNormalized(id.Value, _prjName__normalized, privateToken);

		}
	}
}