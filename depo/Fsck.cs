using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	static public class _FsckX
	{
		/// <summary>
		/// </summary>
	
		static public void Unreachable(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(gitTop, "fsck --unreachable",git);
		}

		/// <summary>
		/// would show dangling objects
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		static public void NoReflogs(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(gitTop, "fsck --no-reflogs",git);
		}



	}
}
