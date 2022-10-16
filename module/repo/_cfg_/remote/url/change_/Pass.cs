using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remote.url.key
{
	public class _SetX
	{

		/*
		 git remote set-url origin git@github.com:<username>/<project>.git

			Internally, the git remote set-url command calls git config remote, but has the added benefit of reporting back any errors. git config remote on the other hand, will silently fail if you mistype an argument or option and not actually set anything. 

			fatal: No such remote '<given remote>' if no such remote.

			 */
		static public void ByRemoteCmd(nilnul.fs.folder_.git_.Top folder, string remote, string key, nilnul.win.prog_.Git git=null)
		{

			var oldUrl = repo._cfg_.remote.url._VwX1.Exe(folder, remote, git);

			var parsed = nilnul.web.url._ParseX3.Parse(oldUrl);

			 parsed.origin.authority.credential.password = new web._url._origin._authority._credential.Key( key);

			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(folder, $"remote set-url {remote} {parsed}");


		}
	}
}
