using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.staged.commit_
{
	[Obsolete(nameof(index.commit_._AllowEmptyX))]
	static public class _AllowEmptyX
	{

		static public void Exe(nilnul.fs.folder_.git_.Top module, nilnul.fs.git.module.staged._commit.Msg _msg_noQuotationMark, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.Git.RunCmd_retVoid(
				module
				,
				$"commit --allow-empty  -m\"{_msg_noQuotationMark}\""
				,git

				);
		}

		static public void Exe( string module, string _msg_noQuotationMark, nilnul.win.prog_.Git git=null)
		{
			Exe(
				new fs.folder_.git_.Top(module)
				, new _commit.Msg(_msg_noQuotationMark)
				,git
			);
		}



	}
}
