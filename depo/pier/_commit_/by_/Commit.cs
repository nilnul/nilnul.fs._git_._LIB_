using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;
using nilnul.fs.folder_.git_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.index
{
	/// <summary>
	/// creatge snap and move branch
	/// </summary>
	static public class _CommitX
	{
		public static void Exe(Top gitTop, string commitMsg, Git git)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				gitTop
				,
				$@"commit -m""{commitMsg.Replace(@"""", "_")}"""
				,
				git
			);

		}

		static public void Exe(nilnul.fs.FolderI workingDir, string commitMsg, Git git=null)
		{
			Exe(new Top(workingDir),commitMsg,git );
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
