using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.history
{
	static public class _VwX
	{
		/*
		 git reflog {bra}
		 */

		static public os.proc_.finished._result.CodMsgErr _Result_addressAssumeModule_assumeBranch(
			string _addressAssumeModule
			,
			string _assumeBranch
			,
			nilnul.os.prog_.Git git = null
		)
		{
			return nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(
				_addressAssumeModule
				,
				$"reflog {_assumeBranch}"
				,
				git
			);
		}
	}
}