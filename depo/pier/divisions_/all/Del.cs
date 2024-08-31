using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.divisions_.all
{
	public class _DelX
	{


		/*
		 git rm --cached <submodule indexed>
		 */

		/*

	git rm --cached -r vendor/plugins/delayed_job

	 */

		/*
				git reset myfile


				This should not affect your local copy or anyone else's.

		reset only removes the file from the index if the file isn't in the current HEAD commit, otherwise it just reverts the index version to the current HEAD version. – Charles Bailey Apr 9 '10  

			*/


		static public void RemoveAll(string module, Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(module, "rm --cached -r -f .", git);


		}




	}
}
