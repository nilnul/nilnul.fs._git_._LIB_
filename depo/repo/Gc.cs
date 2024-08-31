using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	static public class _GcX
	{
		/// <summary>
		/// To remove all dangling commits and those reachable from the reflogs do this:
		///git reflog expire --expire-unreachable=now --all
		///git gc --prune=now

		/// </summary>

		static public void ExpireAll(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git=null) {

			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(gitTop, "gc --prune=now",git);
		}

		



	}
}
