using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ResetX

	{
		/*
		
		 git reset : Clears your index, leaves your working directory untouched. (simply unstaging everything)

git reset --hard : Clears your index, reverts all changes in your working directory to the last commit. (the same thing as svn revert would do)

		 */


		static public void _Exe( nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(gitTop, "reset", git);
		}

		static public void _Exe( nilnul.fs.Folder gitTop, nilnul.win.prog_.Git git=null) {
			_Exe( new fs.folder_.git_.Top(gitTop),git);
		}

	}
}
