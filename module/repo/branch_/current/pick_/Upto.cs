using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current.pick_
{
	static public class _UptoX
	{
		static public void Upto(nilnul.fs.Folder _module, string remote, string branch) {
			Upto(nilnul.win.prog_.Git.StaticInstance,_module, remote,branch);

		}

		static public void Upto(nilnul.win.prog_.Git git,nilnul.fs.Folder _module, string remote, string branch) {
			_PickX.Pick(git, _module, $"..remotes/{remote}/{branch}");

		}

	}
}
