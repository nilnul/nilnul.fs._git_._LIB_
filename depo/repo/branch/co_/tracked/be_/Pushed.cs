using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.co_.tracked.be_
{
	static public class _PushedX
	{
		/*compare the referenced snap*/
		static public bool IsDefinitelyPushed(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.repo._branch.Name branch
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remote
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.txt.nulable.eq_.NulUneq.Singleton.Equals(
				nilnul.fs.git.module.repo.branch.snap._VwX.MsgNulTrimmed(
					module, fs.git.repo._reference.Name.OvBranch(branch)
					,
					git
				)
				,
				nilnul.fs.git.module.repo.branch.snap._VwX.MsgNulTrimmed(
					module,
					fs.git.repo._reference.Name.OvRemoteBranch(remote, branch)
					,
					git
				)


			);
		}
	}
}
