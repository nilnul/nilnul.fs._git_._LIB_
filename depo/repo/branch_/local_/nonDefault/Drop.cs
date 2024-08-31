using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.local_.nonDefault
{
	static public class _DropX
	{
		/*
		 $ git branch -d <branch_name>

			The -d option stands for --delete, which would delete the local branch, only if you have already pushed and merged it with your remote branches.

			Delete a branch. The branch must be fully merged in its upstream branch, or in HEAD if no upstream was set with --track or --set-upstream-to.
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
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				top
				,
				$"branch -d {branch}"
				,git
			);
		}

		static public void Drop(
			nilnul.fs.git.ModuleI top,
			_branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		)
		{
			_Drop(top,branch,git);
		}

		static public void Drop(
			nilnul.fs.folder_.git_.Top top,
			_branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				top
				,
				$"branch -d {branch}"
				,git
			);
		}
		static public void Drop(
			nilnul.fs.folder_.git_.Top top,
			string branch
			,
			nilnul.win.prog_.Git git=null
		) {
			Drop(top, new _branch.Name(branch),git);
		}


	}
}
