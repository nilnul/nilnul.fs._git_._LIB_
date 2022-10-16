using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current
{
	static public class _PickX
	{
		static public void Pick(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string commits) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"cherry-pick {commits}");
		}

		static public void Pick( nilnul.fs.Folder _module, string commits) {
			Pick(nilnul.win.prog_.Git.StaticInstance, _module,commits);
		}

	}
}
