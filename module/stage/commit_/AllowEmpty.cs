using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.commit_
{
	static public class _AllowEmptyX
	{

		static public nilnul.win.prog._run.Result Result(nilnul.fs.git.ModuleI module, nilnul.fs.git.module.index._commit.Msg _msg_noQuotationMark, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run._ResultX.Result(
				module
				,
				$"commit --allow-empty  -m\"{_msg_noQuotationMark}\""
				,git

				);
		}

		static public nilnul.win.prog._run.Result Result( string module, string _msg_noQuotationMark, nilnul.win.prog_.Git git=null)
		{
			return Result(
				 fs.git.Module.FroAddress(module)
				,
				 new _commit.Msg(_msg_noQuotationMark)
				,
				 git
			);
		}



	}
}
