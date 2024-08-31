using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;

namespace nilnul.fs.git.module.index
{
	/// <summary>
	/// the parents,
	/// the commiter,
	/// the message,
	/// the tree
	/// </summary>
	static public class _CommitX
	{
		
		public static void Exe(nilnul.fs.folder_.git_.Top gitTop, _commit.Msg commitMsg, nilnul.win.prog_.Git git=null)
		{

			nilnul.win.prog_.Git.RunCmd_retVoid(gitTop,commitMsg,git);

			//throw new NotImplementedException();
		}

		public static void Exe(nilnul.fs.folder_.git_.Top gitTop, string commitMsg, nilnul.win.prog_.Git git=null)
		{
			Exe(gitTop, new _commit.Msg(commitMsg),git);

			//throw new NotImplementedException();
		}




		static public void Exe(string workingDir, string commitMsg
			, nilnul.win.prog_.Git git=null
		)
		{
			Exe( fs.folder_.git_.Top.FroAddress(workingDir), commitMsg,git);

		}

		static public void Exe(nilnul.fs.FolderI workingDir, string commitMsg
			, nilnul.win.prog_.Git git=null
			
		)
		{
			Exe(new fs.folder_.git_.Top(workingDir), commitMsg, git);

		}



		/*
		.by using the -a switch with the commit command to automatically "add" changes from all known files (i.e. all files that are already listed in the index) and to automatically "rm" files in the index that have been removed from the working tree, and then perform the actual commit;

		

-a 

--all 
Tell the command to automatically stage files that have been modified and deleted, but new files you have not told nilnul.win.prog_.Git about are not affected

		 */


	}
}
