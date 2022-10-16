using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.co.be_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DestinationsDifX
	{
		/*To compare the current branch against master

$ git diff --name-status master
To compare any pair of branches

$ git diff --name-status firstbranch..yourBranchName
That should do what you need, if I understand you correctly.

 */

		/*git diff ..branch_2 compares the checked out branch to branch_2*/

		/*git diff branch_2 compares the checked out branch to branch_2*/

		static public bool Any(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._branch.Name branch
			,
			nilnul.fs.git.module.repo._branch.Name branch1
			,
			nilnul.win.program_.Git git=null
		) {
			return !nilnul.txt.nulable.be_.Nul0White.Singleton.be(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module,$"diff --name-only {branch}..{branch1} --",git) /*replace ".." with " ", we will get the same*/
			); //name-status
		}

		static public bool Any(
			nilnul.fs.git.ModuleI module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.program_.Git git=null
		) {
			return Any(
				module
				, 
				new _branch.Name(branch)
				,
				new _branch.Name(branch1)
				,
				git
			);
		}

		static public bool Any_ofModuleAddress(
			string module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.program_.Git git=null
		) {
			return Any(
				nilnul.fs.git.Module3.FroAddress(module)
				, 
				new _branch.Name(branch)
				,
				new _branch.Name(branch1)
				,
				git
			);
		}




	}
}
