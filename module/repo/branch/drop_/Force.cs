using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.branch.drop_
{
	static public class _ForceX
	{
		/*
		 $ git branch -d <branch_name>

			
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
				$"branch -D {branch}"
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
			nilnul.fs.git.Module top,
			_branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Drop((nilnul.fs.git.ModuleI)top,branch,git);
		}


		static public void Drop(
			string top,
			_branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		) {
			Drop(nilnul.fs.git.Module.FroAddress(top),branch,git );
		}

		public static void Drop(ModuleI module, string v, win.prog_.Git git=null)
		{
			Drop(module, new _branch.Name(v), git);
		}

		static public void Drop(
			nilnul.fs.folder_.git_.Top top,
			_branch.Name branch
			,
			nilnul.win.prog_.Git git=null
		) {
			Drop( 
				top.ToString(),branch,git
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
