using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap._vw_.by_
{
	static public class _ByCatFileX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		///This works with shallow clones, and their grafted commits as listed in the shallow file.
		/// </remarks>
		/// stackoverflow.com/questions/44112593/how-to-get-the-parent-of-a-specific-commit-in-git
		/// <param name="depo"></param>
		/// <param name="snap"></param>
		/// <param name="git"></param>
		/// <returns>
		/// eg:
		///		tree tree_id
		///		parent parent_commit_id
		///		[parent other_parent_commit_id] # present only in case of merge commits
		///		author xxx <xxx@email.com> 1513768542 +0530
		///		committer xxx <xxx@email.com> 1513768542 +0530 
		/// </returns>
		static public string _Msg_0depo_1snap(
			string depo
					,
			string snap
					,
			nilnul.os.prog_.Git git = default
		)
		{

			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo,
				$"cat-file -p {snap}"
					/// where "p" means patch?
				,
				git
			);
		}
	}
}
