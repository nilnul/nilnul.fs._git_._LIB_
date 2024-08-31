using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current
{
	/// <summary>
	/// merge into current branch, even name differs.
	/// </summary>
	static public class _PullX
	{
		/// <summary>
		/// Incorporates changes from a remote repository into the current branch. In its default mode, git pull is shorthand for git fetch followed by git merge FETCH_HEAD.
		/// {repository} should be the name of a remote repository as passed to git-fetch[1]. <refspec> can name an arbitrary remote ref (for example, the name of a tag) or even a collection of refs with corresponding remote-tracking branches(e.g., refs/heads/*:refs/remotes/origin/*), but usually it is the name of a branch in the remote repository.
		/// Default values for {repository} and {branch} are read from the "remote" and "merge" configuration for the current branch as set by git-branch[1] --track.
		/// In its default mode, git pull is shorthand for git fetch followed by git merge FETCH_HEAD.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="folder"></param>
		/// <param name="remote"></param>

		static public void Pull_assumeRemoteIsDefault4currentBranch(
			 nilnul.fs.Folder folder, string remote, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				folder,
				$"pull {remote}"
				,git
			);
		}

		



		static public void Pull( nilnul.fs.Folder folder, string remote, nilnul.win.prog_.Git git=null)
		{
			nilnul.fs.git.module.repo.branch._PullX.Pull(
				
				folder, 
				remote, 
				nilnul.fs.git.module.repo.branch_.current._VwX.Txt(folder)
			);
		}

	

	}
}
