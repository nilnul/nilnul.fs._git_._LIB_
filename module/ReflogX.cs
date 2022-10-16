using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// in lines which include staged.
	/// </summary>
	static public class _ReflogX
	{
		/// <summary>
		/// To remove all dangling commits and those reachable from the reflogs do this:
		///git reflog expire --expire-unreachable=now --all
		///git gc --prune=now
		/// </summary>

		static public void ExpireAll(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git) {
			nilnul.win.prog_.git.run._ResultX.Result(gitTop, "reflog expire --expire-unreachable=now --all");
		}

		



	}
}
