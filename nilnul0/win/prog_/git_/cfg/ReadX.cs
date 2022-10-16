using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.git_.cfg
{
	static public class _ReadX
	{
		static public string Msg(nilnul.fs.address_.spear_.ParentDoc file, string key, nilnul.win.prog_.Git git=null) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				file.parent
				,
				$"config -f {nilnul.fs._address.doc.phrase_.QuoteIfHasWhite.Singleton.phrase( file.doc )} {key}"
				,git
			);
		}

		public static string Msg(
			Spear spear1
					, string key,
			nilnul.win.prog_.Git git = null

		)
		{
			return Msg(new fs.address_.spear_.ParentDoc(spear1), key, git);
		}


		public static string Msg(
			string file, string key, nilnul.win.prog_.Git git = null
		)
		{
			return Msg(nilnul.fs.address_.Spear.Parse(file), key, git);
		}



	}
}
