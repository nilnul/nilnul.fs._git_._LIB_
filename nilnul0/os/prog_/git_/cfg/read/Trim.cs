using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;

namespace nilnul.win.prog_.git_.cfg.read
{
	static public class _TrimmedX
	{
		

		public static string MsgTrimmed(
			nilnul.fs.address_.spear_.ParentDoc file
			, string key, nilnul.win.prog_.Git git=null
		)
		{
			return _ReadX.Msg(file, key, git).Trim();
		}

		public static string MsgTrimmed(
			Spear spear1
					, string key,
			nilnul.win.prog_.Git git=null
	
		)
		{
			return MsgTrimmed( new fs.address_.spear_.ParentDoc(spear1),key,git);
		}


		public static string MsgTrimmed(
			string file, string key, nilnul.win.prog_.Git git=null
		)
		{
			return MsgTrimmed( nilnul.fs.address_.Spear.Parse(file),key,git);
		}

	}
}
