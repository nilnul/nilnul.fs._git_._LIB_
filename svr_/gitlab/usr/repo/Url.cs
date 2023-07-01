using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.client.repo
{
	//[Obsolete(nameof(nilnul.fs.git.svr_.gl.acc.repo._UrlX))]
	public class Url
	{

		/// <summary>
		/// assume repoName is unnormed.
		/// </summary>
		/// <param name="userAddress"></param>
		/// <param name="repo"></param>
		/// <returns></returns>
		static public string _CreateFroUserRepo_assumeUnnormed(
			string userAddress
			,
			string repo
		) {
			return _UrlX._Gen_repoAssumeUnnormed(userAddress,repo);
			//return $"{userAddress}/{nilnul.fs.git.svr_.gitlab.repo._NameX.Encode(repo)}.git";
		}

		[Obsolete( nameof(_CreateFroUserRepo_assumeUnnormed))]
		static public string CreateFroUserRepo0(
			string userAddress
			,
			string repo
		) {
			return _CreateFroUserRepo_assumeUnnormed(userAddress,repo);
			//return $"{userAddress}/{nilnul.fs.git.svr_.gitlab.repo.name.Normalize.Singleton.eval(repo)}.git";
		}

	}



}
