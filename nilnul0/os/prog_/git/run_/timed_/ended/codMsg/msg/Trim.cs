using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;

namespace nilnul.win.prog_.git.run_.timeout.codMsg.msg
{
	public class Trim : nilnul.win.prog_.git.run.codMsg.msg.TrimI
	{
		public string msg(FolderI folder, string arg, Git git = null)
		{
			return nilnul.win.proc_.timeout_.end.codMsg.msg.Trim.Singleton.msg(
				nilnul.win.prog_.git.nulable.Fallback.NotNul(git).val.location
				,
				arg
				,
				folder
			);
		}


		static public Trim Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Trim>.Instance;
			}
		}

	}
}
