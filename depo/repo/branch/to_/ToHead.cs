using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.move_
{
	static public class _ToHeadX
	{
		/// <summary>
		/// 
		/// <start-point> The new branch head will point to this commit.It may be given as a branch name, a commit-id, or a tag.If this option is omitted, the current HEAD will be used instead.
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="branch"></param>
		/// <param name="git"></param>
		static public void ToHead(nilnul.fs.Folder gitTop, nilnul.win.prog_._git.Arg branch, Git git = null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				gitTop
				,
				$"branch -f {branch}"   //newTip is optional;
			);
		}
		static public void ToHead(nilnul.fs.Folder gitTop, string branch, Git git = null)
		{
			ToHead(gitTop, new win.prog_._git.Arg(branch), git);
			
		}



	}
}
