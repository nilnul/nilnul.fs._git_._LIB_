using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current
{
	static public class _MergeX
	{
		static public void Merge(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string otherBranch) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"merge {otherBranch} --allow-unrelated-histories");
		}
	}
}
