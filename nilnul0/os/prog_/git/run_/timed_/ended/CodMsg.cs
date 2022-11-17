using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.win.proc_.timeout_.end;
using nilnul.win.prog._run._result;

namespace nilnul.win.prog_.git.run_.timeout
{

	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(
		"the err output shall be throw;"
		)]
	public class CodMsg
		:
		win.prog_.git.run.CodMsgI

	{

		public prog._run._result.CodMsg codMsg(FolderI folder, string arg, Git git = null)
		{
			var r = os.prog_.git.run_.timed_.ended._ResultX.Result(folder, arg, git);
			return new prog._run._result.CodMsg(r.exitCode,r.msg);
			//return nilnul.win.proc_.timeout_.end.CodMsg.Singleton.codMsg(nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location, arg, folder);
		}


		static public CodMsg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<CodMsg>.Instance;
			}
		}

	}
}
