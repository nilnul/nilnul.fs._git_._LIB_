using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.awGlBbVs.powsub.next
{
	static public class _EnsureSvrFirstX
	{


		static public IEnumerable<string> Results(string gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return Results( fs.folder_.git_.Top.FroAddress(gitTop), svrRepoName, git);
		}


		static public IEnumerable<string> Results(nilnul.fs.folder_.git_.Top gitTop,  string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			yield return remote_.vs_.next.create.ensureSvrFirst_._UsrCfgedX.Json(gitTop, svrRepoName);
			yield return remote_.aw_.next.create_.ohio._EnsureSvrFirst4VaultedCredX.Json(gitTop, svrRepoName);
			yield return remote_.gl_.next.create_._CfgedUsrX.Id(gitTop, svrRepoName).ToString();
			yield return remote_.bb_.next.create_.vaultedCred._EnsureSvrFirstX.Result(gitTop, svrRepoName).ToString();
			yield return remote_.awGlBbVs_.next._CreateX.Result(gitTop, git).ToString();

		}




	}
}
