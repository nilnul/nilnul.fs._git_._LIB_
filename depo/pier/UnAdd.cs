using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage
{
	public class UnAdd
	{
		/*
		 

This should unstage a <file> for you (without removing or otherwise modifying the file):
git reset HEAD <file>

This removes the latest change for the specific file but keeps it in the repo (remote) after commit and push. – powder366 Jun 30 '16 at 6:25  
 
 */



		/*
				git reset myfile


				This should not affect your local copy or anyone else's.



		reset only removes the file from the index if the file isn't in the current HEAD commit, otherwise it just reverts the index version to the current HEAD version. – Charles Bailey Apr 9 '10  

			*/
		static public void UnAddAll(string module) {

			nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(module, "reset");

		}

		public static void UnStage(fs.Folder _module)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(_module, "rm --cached -r .");


		}

		static public void UnStage(string module) {

			nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(module, "rm --cached -r .");

		}






	}
}
