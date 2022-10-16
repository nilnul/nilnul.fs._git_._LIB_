using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remote.url
{
	[Obsolete(nameof(module.repo._cfg_.remote.url._AssignX))]
	public class Set
	{

		
		static public void ByRemoteCmd(Folder folder, string remote, string url, Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void( folder, $"remote set-url {remote} {url}",git);


		}
	}
}
