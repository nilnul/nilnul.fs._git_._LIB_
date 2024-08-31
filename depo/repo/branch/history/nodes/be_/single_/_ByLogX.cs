using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.branch.history.nodes.be_.single_
{
	static public class _ByLogX
	{

		static public bool _Is_0moduleAddress_1branch(
			string _addressAssumeModule
			,
			string _assumeBranch
			,
			nilnul.os.prog_.Git git = null
		)
		{

			var r =  nilnul.os.prog_.git.run_.exit._ResultX._Result_assumeAddress(
				_addressAssumeModule
				,
				$"log --pretty=%P -n 1 {_assumeBranch}" // if the branch has no commits: fatal: your current branch 'someBranch' doesnot have any commits yet
				,
				git
			);  // where %P may mean parent;  shows the parent hash, or empty if there is no parent.

			if (r.beErr)
			{
				throw new Exception( $"when getting recent two snaps of the history for branch:{_assumeBranch}, result:{r.ToString()}");
			}

			return string.IsNullOrWhiteSpace(r.msg); 

		


		}
	}
}