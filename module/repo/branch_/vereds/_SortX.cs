using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.vereds
{
	static public class _SortX
	{
		static public IEnumerable<nilnul.txt_.Vered> Seq(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.repo._branch.name_._vered.Key branch
			,
			nilnul.win.prog_.Git git = null
		) {
			return nilnul.txt_.vered.str.op_.unary_._SortX.Seq(
				branch_._VeredsX.Vereds(module, branch, git)
			);
		}
	}
}
