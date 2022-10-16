using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;

namespace nilnul.fs.git.module.repo.snap
{
	/// <summary>
	/// the parents,
	/// the commiter,
	/// the message,
	/// the tree
	/// </summary>
	public class _AmendX
	{
		static public void _Void_ofAddress( string module, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				module
				,
				$"commit --amend --no-edit"
			);
		}

		/*
		.by using the -a switch with the commit command to automatically "add" changes from all known files (i.e. all files that are already listed in the index) and to automatically "rm" files in the index that have been removed from the working tree, and then perform the actual commit;
-a 

--all 
Tell the command to automatically stage files that have been modified and deleted, but new files you have not told nilnul.win.prog_.Git about are not affected

		 */
	}
}
