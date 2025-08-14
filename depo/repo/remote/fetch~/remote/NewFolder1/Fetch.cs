using nilnul.dev.git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo
{
	public static class _FetchX
	{
		/// <summary>
		/// Incorporates changes from a remote repository into the current branch. In its default mode, git pull is shorthand for git fetch followed by git merge FETCH_HEAD.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="folder"></param>
		/// <param name="remote"></param>

		
		static public void Fetch(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote) {
			git.runCmd_throwErr(
				folder,
				$"fetch {remote}"
			);
		}

		static public void Fetch(nilnul.fs.Folder folder, string remote) {
			Fetch(nilnul.win.prog_.Git.StaticInstance, folder,remote);
		}

		

	}
}
