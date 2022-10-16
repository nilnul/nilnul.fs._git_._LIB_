using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.vered_.key
{
	static public class _DelX
	{
		static public void _Del(
			nilnul.fs.folder_.git_.Top top,
			nilnul.txt_._vered_.Name _branchName, 
			nilnul.win.prog_.Git git=null 
		) {
			var branch = new nilnul.fs.git.module.repo._branch.Name(_branchName);
			var ids = repo.branches_.local._VwX.CurrentAndRemaining(top, git).Where(x=>
				nilnul.txt_._NameVerX.IsNamedAs(_branchName,x)
			);
			nilnul.fs.git.module.repo.branches._DelX.Del(top, ids,git);
		}

		static public void _Del(
			nilnul.fs.folder_.git_.Top top,
			string _branchName, 
			nilnul.win.prog_.Git git=null 
		) {
			_Del(top,_branchName,git);
		}




	}
}
