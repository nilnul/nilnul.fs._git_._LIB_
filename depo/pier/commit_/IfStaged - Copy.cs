using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.staged.commit_
{
	/// <summary>
	/// if no staged, nop; else commit
	/// </summary>
	static public class _IfStagedX
	{
		static public void Exe(nilnul.fs.folder_.git_.Top gitTop, string commitMsg, nilnul.win.prog_.Git git = null) {
			if ( ! nilnul.fs.git.module.staged.be_.empty_.DryRun.Be(gitTop) )
			{
				nilnul.fs.git.module.staged.Commit.Exe(gitTop, commitMsg, git);
			}

		}

		static public void Exe(nilnul.fs.Folder gitTop, string commitMsg, nilnul.win.prog_.Git git = null) {
			Exe(new fs.folder_.GitTop(gitTop), commitMsg, git);

		}

	}
}
