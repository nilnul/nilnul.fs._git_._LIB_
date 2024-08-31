using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_._destinys_.by_
{
	/// <summary>
	/// 
	/// </summary>
	static  class _LsFilesX
	{
		static public string Msg(string depo) {
			return nilnul.os.prog_.git.run_.exit.result._MsgX._GetMsg_0depo_1argument(
				depo
				,
				"ls-files --others --modified --deleted --exclude-standard"
			/// https://stackoverflow.com/a/72721219/8487674
			/// Simple way to get all new, modified and removed files:
			/// git ls-files --others --modified --deleted --exclude-standard
			/// Refer to official documentation: https://git-scm.com/docs/git-ls-files
			/// Use "--others" if you wish to see new/untracked files
			/// Use "--modified" if you wish to see modified files
			/// Use "--deleted" if you wish to see deleted files
			/// --exclude-standard will exclude the files specified in .gitignore
			);
		}
	}
}
