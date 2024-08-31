using nilnul.dev.git.module;
using nilnul.fs;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.commit_
{
	static public class _AllowEmptyX
	{


		static public void __ofAddress( string module, string _msg_noQuotationMark, nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(
				module
				,
				$"commit --allow-empty  -m\"{_msg_noQuotationMark}\""
				,git
			);
		}

		static public void _Commit( Folder folder, string _msg_noQuotationMark, nilnul.win.prog_.Git git=null) {

			__ofAddress(folder.ToString(),_msg_noQuotationMark, git);
		}


		

		
	}
}
