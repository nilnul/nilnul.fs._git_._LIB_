using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.branch_.current.snap
{
	/// <summary>
	/// git reset --soft
	/// </summary>
	/// "File in stage is unchanged" can be confirmed by the output of git ls-files -s showing that the SHA for a file is unchanged.
	static public class _AssignX
	{

		/// stackoverflow.com/questions/1282639/switch-git-branch-without-files-checkout 
		/// answered Jul 12, 2017 at 14:10
		/// Tino
		/// 
		/// git checkout --detach
		/// git reset --soft commitish
		/// 
		/// then moves HEAD to the SHA of the given commitish. If you want to update the index, too, leave --soft away, but I do not recommend to do so. This, again, does not touch the worktree, and (--soft) not the index.
		/// 
		/// <summary>
		/// </summary>
		/// <remarks>
		/// would throw exception if there is no defaulted commit;
		/// </remarks>

		static public void _Vod_addressAssumeModule_assumeSnap(string _addressAssumeModule, string _assumeSnap
			,
			nilnul.os.prog_.Git git = null
		)
		{

			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
				_addressAssumeModule
				,
				$"reset --soft {_assumeSnap}" ///resets the current branch head to <commit>;  Before the operation, ORIG_HEAD is set to the tip of the current branch.
											  /// by "--soft", Does not touch the index file or the working tree at all (but resets the head to <commit>, just like all modes do). This leaves all your changed files "Changes to be committed", as git status would put it.
											  /// src: git-scm.com/docs/git-reset

				,
				git
			);
		}
	}
}

