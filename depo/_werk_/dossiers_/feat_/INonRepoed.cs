using nilnul.fs.git.depo.pier.commit_;
using nilnul.fs.git.module.repo.snaps;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo._werk_.dossiers_.feat_
{
	/// <summary>
	/// not in any snap, including any branch,tag or HEAD, of the repo.
	/// 
	/// </summary>
	/// for dangling snap, which is to be pruned, we are unsure.
	interface INonRepoed
	{
	}

	static public class _NonRepoedX
	{
		static public IEnumerable<string> Dossiers(string depo, nilnul.os.prog_.Git git = default)
		{

		
			return _IncludedX._Denotions_0depo(depo, git).Except(
			 
				destinys_._RepoedX._Destinys_0depo(depo,git)
			);
		}

	}
}
