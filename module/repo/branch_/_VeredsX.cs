using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_
{
	static public class _VeredsX
	{
		static public IEnumerable<nilnul.txt_.Vered> Vereds(
			nilnul.fs.git.ModuleI module
			, 
			nilnul.fs.git.repo._branch.name_._vered.Key branch
			,
			nilnul.win.prog_.Git git=null
		) {

			return nilnul.fs.git.module.repo.branches_.local._VwX.CurrentAndRemaining(module, git).Select(x=> nilnul.txt_.Vered.Parse(x) ).Where(
				b=>nilnul.txt_.vered.be_._NamedAsX.Be(branch,b)
			);
		}


	}
}
