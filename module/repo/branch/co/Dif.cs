using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.duo
{
	/*
	git log origin...master
		 */
	static public class _DifX
	{
		/// <summary>
		/// git diff --name-only branch1 master
		/// git diff other_branch this_branch
		/// will show me all differences, but files that don't exist in the current branch have no special indicator in that list
		/// </summary>
		/// <returns></returns>
		static public string Dif(nilnul.win.prog_.Git git, string _module, string branch, string branch1) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, $"diff  {branch} {branch1}");
		}


		/// <summary>
		/// git diff --name-only branch1 master
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <param name="branch"></param>
		/// <param name="branch1"></param>
		/// <returns></returns>
		static public string Dif_nameOnly(nilnul.win.prog_.Git git, string _module, string branch, string branch1) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, $"diff --name-only {branch} {branch1}");
		}

		/// <summary>
		/// git diff-tree -r --diff-filter=D branchA branchB
		/// •D: sort files existing in branch1 only.
		/// •M: sort files have been modified
		/// •A: sort files existing in branch2 only.
		/// You can use all of them at the same time, also with "--stat" flag for a quick view of the changes.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <param name="branch"></param>
		/// <param name="branch1"></param>
		/// <returns></returns>
		static public string DifTree_deletedInLatter(nilnul.win.prog_.Git git, string _module, string branch, string branch1) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, $"diff-tree -r --diff-filter=D {branch} {branch1}");
		}

		static public string DifTree_deletedInLatter_nameOnly(nilnul.win.prog_.Git git, string _module, string branch, string branch1) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, $"diff-tree -r --diff-filter=D --name-only {branch} {branch1}");
		}




		static public string DifTree_addedInLatter(nilnul.win.prog_.Git git, string _module, string branch, string branch1) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, $"diff-tree -r --diff-filter=A {branch} {branch1}");
		}

		/// <summary>
		/// If there is only one <tree-ish> given, the commit is compared with its parents (see --stdin below).
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <param name="branch"></param>
		/// <returns></returns>
		static public string DifTree_deletedInThis(nilnul.win.prog_.Git git, string _module, string branch) {

			var currentBranch = nilnul.fs.git.module.repo.branch_.current._VwX.Txt_ofAddress(_module,git);

			return DifTree_deletedInLatter(git, _module, branch,currentBranch);
		}


		static public string DifTree_deletedInThis_nameOnly(nilnul.win.prog_.Git git, string _module, string branch) {

			var currentBranch = nilnul.fs.git.module.repo.branch_.current._VwX.Txt_ofAddress(_module,git);

			return DifTree_deletedInLatter_nameOnly(git, _module, branch,currentBranch);
		}


		static public string DifTree_deletedInThis_nameOnly( string _module, string branch) {

			

			return DifTree_deletedInThis_nameOnly(nilnul.win.prog_.Git.StaticInstance, _module, branch);
		}




		static public string DifTree_deletedInOther(nilnul.win.prog_.Git git, string _module, string branch) {

			var currentBranch = nilnul.fs.git.module.repo.branch_.current._VwX.Txt_ofAddress(_module);

			return DifTree_deletedInLatter(git, _module, currentBranch, branch);
		}




		static public string DifTree_addedInOther(nilnul.win.prog_.Git git, string _module, string branch) {
			var currentBranch = nilnul.fs.git.module.repo.branch_.current._VwX.Txt_ofAddress(_module,git);

			return DifTree_addedInLatter(git, _module, branch,currentBranch);

		}

		static public string DifTree_deletedInThis( string _module, string branch) {
			return DifTree_deletedInThis(nilnul.win.prog_.Git.StaticInstance, _module, branch);
		}



		static public string Dif(nilnul.win.prog_.Git git, string _module, string branch) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(_module, $"diff --name-only {branch}");
		}


		static public string Dif( string _module, string branch, string branch1) {
			return Dif(nilnul.win.prog_.Git.StaticInstance, _module,branch,branch1);
		}

		static public string Dif( string _module, string branch) {
			return Dif(nilnul.win.prog_.Git.StaticInstance, _module,branch);
		}


	}
}
