using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.remote.drop_
{
	[Obsolete("branch -D doesn't not work for remote branch; see "+ nameof(repo.remote.branch.Drop))]
	static public class _ForceX
	{
		/*
		 $ git branch -d <branch_name>

			The -d option stands for --delete, which would delete the local branch, only if you have already pushed and merged it with your remote branches.
		 */

		/*
If there are unmerged changes which you are confident of deleting:
$ git branch -D <branch_name>
		 */

		static public void _Drop(
			nilnul.fs.git.ModuleI top,
			string branch
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				top
				,
				$"branch -dr {branch}" /*git branch --delete --remotes <remote>/<branch>
				git branch - dr < remote >/< branch > # Shorter*/
				, git
			);
		}
		static public void _Drop(
			string top,
			string _branch
			,
			nilnul.win.prog_.Git git=null
		) {
			_Drop(nilnul.fs.git.Module.FroAddress(top),_branch,git );
		}
	

	}
}
