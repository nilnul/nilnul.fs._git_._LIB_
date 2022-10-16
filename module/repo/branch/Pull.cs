using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch
{
	/// <summary>
	/// merge into current branch, even name differs.
	/// </summary>
	static public class _PullX
	{
		

		static public void Pull(nilnul.fs.Folder folder, string remote, string branch)
		{

			Pull(nilnul.win.prog_.Git.StaticInstance, folder, remote, branch);
		}
		static public void Pull(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote, string branch)
		{

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				folder,
				$"pull {remote} {branch}"
			);
		}




	}
}
