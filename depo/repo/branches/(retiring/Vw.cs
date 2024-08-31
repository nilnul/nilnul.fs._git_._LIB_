using nilnul.win.process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo.branches
{
	[Obsolete()]
	static public class _VwX
	{


		/// <summary>
		///  -a shows all local and remote branches
		/// </summary>
		/// <param name="_gitTop"></param>
		/// <returns></returns>
	

		static public _branches.CurrentAndRemaining _Vw(nilnul.win.prog_.Git git, nilnul.fs.Folder _gitTop)
		{

			var result = git.runCmd__retResult_throwErr(_gitTop, "branch -a");



			var outputBranches = result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

			var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));

			var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

			return new _branches.CurrentAndRemaining(
				nilnul.txt.Opt.CreateFroStr(defaultBranch)
				,
				nonDefaultBranch
			);
		}

		static public _branches.CurrentAndRemaining _Vw( nilnul.fs.Folder _gitTop)
		{
			return _Vw(nilnul.win.prog_.Git.StaticInstance, _gitTop);
		}
	}
}
