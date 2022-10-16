using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// the parents,
	/// the commiter,
	/// the message,
	/// the tree
	/// </summary>
	public class Commit
	{
		static public void _Amend(nilnul.win.prog_.Git git, string module)
		{
			git.runCmd_throwErr(
				module
				,
				$"commit --amend --no-edit"

				);
		}

		static public void _Amend( string module)
		{
			_Amend(nilnul.win.prog_.Git.StaticInstance, module);
		}


		static public void Exe(string workingDir, string commitMsg)
		{
			Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}

		static public void Exe(nilnul.fs.Folder workingDir, string commitMsg)
		{
			Git.StaticInstance.runCmd_throwErr(workingDir, $@"commit -m""{commitMsg.Replace(@"""", "_")}""");

		}

		/*
		.by using the -a switch with the commit command to automatically "add" changes from all known files (i.e. all files that are already listed in the index) and to automatically "rm" files in the index that have been removed from the working tree, and then perform the actual commit;

		

-a 

--all 
Tell the command to automatically stage files that have been modified and deleted, but new files you have not told nilnul.win.prog_.Git about are not affected

		 */


	}
}
