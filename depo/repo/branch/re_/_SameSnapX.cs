using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.branch.re_
{
	/// <summary>
	/// compare the snap of the two branches
	/// </summary>
	static public class _SameSnapX
	{
		

		/// <summary>
		/// 
		/// </summary>
		/// <param name="module"></param>
		/// <param name="branch"></param>
		/// <param name="branch1"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <exception cref="">
		///warning: unable to access 'report_/128...-¬+F+¦¦¿+µ/-°++/.gitattributes': Filename too long
		///		and the returned code is nonnil.
		/// </exception>
		static public bool Re(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._branch.Name branch
			,
			nilnul.fs.git.module.repo._branch.Name branch1
			,
			nilnul.win.prog_.Git git=null
		) {
			nilnul.fs.git.module.repo.cfg.section_.core.Longpaths.EnsureTrue(module, git);

			return fs.git.module.repo.branch.snap._VwX.MsgTrimmed(module, branch,git)
				== fs.git.module.repo.branch.snap._VwX.MsgTrimmed(module, branch1,git);

			return nilnul.txt.nulable.be_.Nul0White.Singleton.be(
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module,$"diff --name-only {branch}..{branch1} --",git) /*replace ".." with " ", we will get the same*/
			); //name-status
		}

		static public bool Re(
			nilnul.fs.git.ModuleI module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.prog_.Git git=null
		) {
			return Re(
				module
				, 
				new module.repo._branch.Name(branch)
				,
				new module.repo._branch.Name(branch1)
				,
				git
			);
		}

		static public bool Re_0depo8address(
			string module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.prog_.Git git=null
		) {
			return Re(
				nilnul.fs.git.Module.FroAddress(module)
				, 
				new module.repo._branch.Name(branch)
				,
				new module.repo._branch.Name(branch1)
				,
				git
			);
		}




	}
}
