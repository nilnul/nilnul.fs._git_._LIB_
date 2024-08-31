using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tag.re_
{
	/// <summary>
	/// diff of two branches;	/// compare the content of the two branches, where the two branch might differ in meta data but same in content;
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
		/// <param name="_depo"></param>
		/// <param name="branch"></param>
		/// <param name="_tag1"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="">
		///warning: unable to access 'report_/128...-¬+F+¦¦¿+µ/-°++/.gitattributes': Filename too long
		///		and the returned code is nonnil.
		/// </exception>
		static public bool _Re_0depo_12tag(
			string _depo
			,
			string _tag
			,
			string _tag1
			,
			nilnul.win.prog_.Git git=null
		) {
			//nilnul.fs.git.module.repo.cfg.section_.core.Longpaths._EnsureTrue_0depo(module, git);
			return nilnul.txt.nulable.be_.Nul0White.Singleton.be(
				nilnul.win.prog_.git.run.result.msg._TrimmedX._Txt_0address_1argument(_depo,$"diff --name-only tags/{_tag}..tags/{_tag1} --",git) /*replace ".." with " ", we will get the same*/
			); //name-status
		}

	




	}
}
