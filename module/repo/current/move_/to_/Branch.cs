using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.head.move_.to_
{
	static public class _BranchX
	{
		static public void ToBranch(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.module.repo._branch.Name branch, nilnul.win.prog_.Git git = null)
		{

			_RefX.ToRef(gitTop, "refs/heads/" + branch, git);

		}
		public static void ToBranch(Top gitTop, string v, Git git=null)
		{
			ToBranch(gitTop, new _branch.Name(v), git);

		}
		static public void ToBranch(nilnul.fs.Folder  module, string _branch_new, nilnul.win.prog_.Git git=null)
		{


			ToBranch(
				new nilnul.fs.folder_.git_.Top(module)

				,
				new nilnul.win.prog_._git.Arg(
				_branch_new)
				,git
			);

		}

	}
}
