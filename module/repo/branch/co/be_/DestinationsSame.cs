using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.co.be_
{
	/// <summary>
	/// diff of two branches
	/// </summary>
	static public class _DestinationsSameX
	{
		/*To compare the current branch against master

$ git diff --name-status master
To compare any pair of branches

$ git diff --name-status firstbranch..yourBranchName
That should do what you need, if I understand you correctly.

 */

		/*git diff ..branch_2 compares the checked out branch to branch_2*/

		/*git diff branch_2 compares the checked out branch to branch_2*/

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="branch"></param>
		/// <param name="branch1"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="">
		///warning: unable to access 'report_/1281650105@qq.com-梦到終时一场空-191221_215111-18080323 付鑫鹏 网页程序设计期末设计报告/_attach_/18080323 付鑫鹏 网页程序设计期末设计报告/18080323 +¦÷++( -°-¦¦¦-=+F+¦¦+-¬+F+¦¦¿+µ/18080323 +¦÷++( -°-¦¦¦-=+F+¦¦+-¬+F+¦¦¿+µ/-°++/.gitattributes': Filename too long
		///		and the returned code is nonnil.
		/// </exception>
		static public bool Be(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._branch.Name branch
			,
			nilnul.fs.git.module.repo._branch.Name branch1
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.fs.git.module.repo.cfg.section_.core.Longpaths.EnsureTrue(module, git);
			return nilnul.txt.nulable.be_.Nul0White.Singleton.be(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module,$"diff --name-only {branch}..{branch1} --",git) /*replace ".." with " ", we will get the same*/
			); //name-status
		}

		static public bool Be(
			nilnul.fs.git.ModuleI module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be(
				module
				, 
				new _branch.Name(branch)
				,
				new _branch.Name(branch1)
				,
				git
			);
		}

		static public bool Be_ofModuleAddress(
			string module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.prog_.Git git=null
		) {
			return Be(
				nilnul.fs.git.Module.FroAddress(module)
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
