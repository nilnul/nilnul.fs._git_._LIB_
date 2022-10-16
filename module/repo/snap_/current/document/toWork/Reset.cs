using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.repo.snap_.current.document.toWork_
{
	static public class _ByResetX
	{

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
				$"reset -- { nilnul.fs._address.document.phrase_.QuoteIfHasSpaceOrTab.Singleton.phrase(file )}"
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
				new nilnul.fs.git. repo._branch.Name(
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
				new nilnul.fs.git. repo._branch.Name(
				branch)
				,
				nilnul.fs._address.Document.Parse(file)
				,git
			);
		}





	}
}
