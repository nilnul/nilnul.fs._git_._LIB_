using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.document.create_.froRepo_.by_
{
	static public class _CheckoutX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="work"></param>
		/// <param name="branch">if the branch name is not initialized(for example on an empty repo with the defaulted "master" branch) an error will be thrown: cannot find the path or sth to the effect</param>
		/// <param name="file"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string Report(
			nilnul.fs.folder_.git_.Work work
			,

			 nilnul.fs.git.module.repo._branch.Name branch
			, 
			 nilnul.fs._address.DocumentI file
			,
			 nilnul.win.prog_.Git git=null
		) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				work.en, 
				$"checkout {branch} -- { nilnul.fs._address.document.phrase_.QuoteIfHasSpaceOrTab.Singleton.phrase(file )}"
				,
				git
			);
		}

		static public string Report_ofAddresses(
			string work
			,

			 nilnul.fs.git.module.repo._branch.Name branch
			, 
			 nilnul.fs._address.DocumentI file
			,
			 nilnul.win.prog_.Git git=null
		) {
			return Report(
				nilnul.fs.folder_.git_.Work.FroAddress(work)
				,branch,file,git
			);
		}

		static public string Report_ofAddresses(
			string work
			,

			 string branch
			, 
			 nilnul.fs._address.DocumentI file
			,
			 nilnul.win.prog_.Git git=null
		) {
			return Report_ofAddresses(
				(work)
				,
				new repo._branch.Name(
				branch),file,git
			);
		}


		static public string Report_ofAddresses(
			string work
			,

			 string branch
			, 
			 string file
			,
			 nilnul.win.prog_.Git git=null
		) {
			return Report_ofAddresses(
				(work)
				,
				new repo._branch.Name(
				branch)
				,
				nilnul.fs._address.Document.Parse(file)
				,git
			);
		}





	}
}
