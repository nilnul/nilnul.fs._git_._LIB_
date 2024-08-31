using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.documents
{
	public class CheckoutFroAnotherBranch
	{

		static public void Eval(FolderI gitFolder, string branch, Git git, params string[] files__eachName_noSpaceNoQuotes) {

			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(gitFolder,
				$"checkout {branch} -- {string.Join(" ",files__eachName_noSpaceNoQuotes )}"
				,
				git
			);
		}
	}
}
