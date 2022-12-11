using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git_.cfg.read_
{
	static public class _ResultX
	{
		static public os.proc_.finished._result.CodMsgErr Result(nilnul.fs.address_.spear_.ParentDoc file, string key, nilnul.win.prog_.Git git=null) {
			return nilnul.os.prog_.git.run_.exit_.onDue._ResultX.Result(
				file.parent
				,
				$"config -f {file.doc} {key}"
				,git
			);
		}

		public static os.proc_.finished._result.CodMsgErr Result(
			Spear spear1
					, string key,
			nilnul.win.prog_.Git git = null

		)
		{
			return Result(new fs.address_.spear_.ParentDoc(spear1), key, git);
		}


		public static os.proc_.finished._result.CodMsgErr Result(
			string file, string key, nilnul.win.prog_.Git git = null
		)
		{
			return Result(nilnul.fs.address_.Spear.Parse(file), key, git);
		}



	}
}
