using nilnul.fs.git.depo.pier.commit_;
using nilnul.fs.git.module.repo.snaps;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.git.depo.repo.snap.dossiers._vs_.by_
{
	/// <summary>
	/// 
	/// </summary>

	static public class _DiffTreeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="depo"></param>
		/// <param name="snap"></param>
		/// <param name="snap1"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<string> _Destinys_0depo_1snap_2snap(string depo, string snap,string snap1, nilnul.os.prog_.Git git = default)
		{

			/// stackoverflow.com/questions/28284890/in-git-how-can-i-list-all-files-that-exist-in-branch-a-that-do-not-exist-in-bra
			///
			///list the names of all files that exist in one branch that do not exist in another branch

			///use -r to recursively descend through subtree and--diff-filter to restrict output to only certain types of diffs (for instance, deletions=D)
			///
			 string argument = $"diff-tree --name-only -r --diff-filter=D {snap} {snap1}";

			///, where in diff-filter:
			///		D: sort files existing in branch1 only.
			///		M: sort files have been modified
			///		A: sort files existing in branch2 only.

			return nilnul.txt.split_._LineX.Line_eachTrim_delEmpty(
				nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
								depo,
								argument
								, git
				)
			);
		}

	}
}
