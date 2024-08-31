using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.history.snaps_.recentTwo_
{
	static public class _ByShowBranchX
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
				$"show-branch --more=2 {_assumeBranch}"
				,
				git
			);
		}

		/// <summary>
		/// list the commit msges ;
		/// </summary>
		/// <param name="_addressAssumeModule"></param>
		/// <param name="_assumeBranch"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public os.proc_.finished._result.CodMsgErr _ResultNoName_0moduleAddress_1branch(
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
				$"show-branch --no-name --more=2 {_assumeBranch}"
				,
				git
			);
		}


	}
}