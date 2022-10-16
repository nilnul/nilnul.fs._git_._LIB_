using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current
{
	public static class _Head2BranchX
	{
		/// <summary>
		/// git symbolic-ref HEAD refs/heads/otherbranch
		/// after this:
		/// If you need to commit on this branch, you'll want to reset the index too otherwise you'll end up committing something based on the last checked out branch.
		///		git reset
		/// </summary>


		static public void Head2Branch(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string _branch)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"symbolic-ref HEAD refs/heads/{_branch}");
		}

		static public void Head2Branch( nilnul.fs.Folder _module, string _branch)
		{
			Head2Branch( nilnul.win.prog_.Git.StaticInstance, _module, _branch);
		}


	}
}
