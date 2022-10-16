using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.snap
{
	/// <summary>
	/// the parents,
	/// the commiter,
	/// the message,
	/// the tree
	/// </summary>
	static public class _CommitX
	{

		static public void Exe(nilnul.fs.FolderI workingDir, string commitMsg, Git git=null)
		{
			nilnul.win.prog_.git.run.result._ThrowErrX.Void(
				workingDir
				,
				$@"commit -m""{commitMsg.Replace(@"""", "_")}"""
				,
				git
			);
		}

		public static void Exe(nilnul.fs.Folder gitTop, string commitMsg, nilnul.win.prog_.Git git=null)
		{
			Exe((FolderI)gitTop,commitMsg,git);
		}

		static public void Exe(string workingDir, string commitMsg, Git git=null)
		{
			Exe(nilnul.fs.Folder.FroAddress(workingDir),commitMsg,git);
		}

		/*
		.by using the -a switch with the commit command to automatically "add" changes from all known files (i.e. all files that are already listed in the index) and to automatically "rm" files in the index that have been removed from the working tree, and then perform the actual commit;


-a 

--all 
Tell the command to automatically stage files that have been modified and deleted, but new files you have not told nilnul.win.prog_.Git about are not affected

		 */


	}
}
