using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current
{
	static public class _CreateBranchX
	{
		static public void Eval(nilnul.fs.Folder gitTop, nilnul.win.prog_._git.Arg newBranch, nilnul.win.prog_.Git git = null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				gitTop, $"checkout -b {newBranch}"
				,
				git
			);
		}

		static public void Eval(nilnul.fs.Folder gitTop, string newBranch, nilnul.win.prog_.Git git = null)
		{
			Eval(gitTop, new win.prog_._git.Arg(newBranch), git);
		}

	}
}
