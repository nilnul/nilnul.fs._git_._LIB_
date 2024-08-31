using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.fs.git.module.index._commit;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.index.commit_.allowEmpty_
{
	static public class _MsgX
	{

		static public string Txt(nilnul.fs.git.ModuleI module, nilnul.fs.git.module.index._commit.Msg _msg_noQuotationMark, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				module
				,
				$"commit --allow-empty  -m\"{_msg_noQuotationMark}\""
				,git

				);
		}
		public static string Txt(fs.git.Module module, Msg msg, Git git)
		{
			return Txt(
				 (ModuleI)(module)
				,
				 (msg)
				,
				 git
			);
			;
		}

		public static string Txt(Top module, Msg msg, Git git)
		{
			return Txt(
				 new fs.git.Module(module)
				,
				 (msg)
				,
				 git
			);
			;
		}

		static public string Txt( string module, string _msg_noQuotationMark, nilnul.win.prog_.Git git=null)
		{
			return Txt(
				 fs.git.Module.FroAddress(module)
				,
				 new _commit.Msg(_msg_noQuotationMark)
				,
				 git
			);
		}



	}
}
