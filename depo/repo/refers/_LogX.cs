using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.refers
{
	/// <summary>
	/// reflog for module in that it contains detached commits which would be gc-ed later.
	/// log for repo in that it contains the commits.
	/// </summary>
	/// <remarks>
	/// in lines which include staged.
	/// </remarks>

	static public class _LogX
	{
		/// <summary>
		/// To remove all dangling commits and those reachable from the reflogs do this:
		///git reflog expire --expire-unreachable=now --all
		///git gc --prune=now
		/// </summary>

		static public void ExpireAll(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git)
		{
			nilnul.win.prog_.git.run._ResultX.Result(gitTop, "reflog expire --expire-unreachable=now --all");
		}








		/// <summary>
		/// in blocks of details including author
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public string Exe(nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_.Git git = null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module,
				"log"
			);
		}



	}
}
