using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.history.snaps_.recentTwo_
{
	static public class _ByRevListX
	{

		static public os.proc_.finished._result.CodMsgErr _Result_0moduleAddress_1branch(
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
				$"rev-list -n 2 {_assumeBranch}"
				,
				git
			);
		}



	}
}