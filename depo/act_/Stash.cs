using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.act_
{

	static public class Stash
	{
		/// <summary>
		/// git stash only deals with tracked files; new files aren't tracked, so they won't get stashed
		/// </summary>
		/// <param name="_module"></param>
		static public void Exe(Folder _module, Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(
				_module
				,
				"stash"
				,git
			);
		}

		/// <summary>
		/// Should you want to stash away untracked files, the thing to do is "git add" them before stashing. That said, I'm not sure you actually want to stash here - if you intend for those changes to be part of the branch you're switching away from, commit them. (If you intend to switch back to that branch and work on the changes more before committing them, then stash may be the right tool for the job.) 
		/// </summary>
		static public void AddAndStash() {

		}
	}
}
