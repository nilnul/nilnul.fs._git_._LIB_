using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.commit_
{
	static public class _AllowEmptyX
	{

		static public os.proc_.finished._result.CodMsgErr Result(nilnul.fs.git.ModuleI module, nilnul.fs.git.module.index._commit.Msg _msg_noQuotationMark, nilnul.os.prog_.Git git=null)
		{
			return nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(
				module
				,
				$"commit --allow-empty  -m\"{_msg_noQuotationMark}\""
				,git

				);
		}

		static public os.proc_.finished._result.CodMsgErr Result( string module, string _msg_noQuotationMark, nilnul.os.prog_.Git git=null)
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
