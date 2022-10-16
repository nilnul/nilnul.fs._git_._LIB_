using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote
{
	static public class _VwX
	{

		/// <summary>
		/// 			Gives some information about the remote {name}.
		/// 			With -n option, the remote heads are not queried first with git ls-remote<name>; cached information is used instead.
		/// git remote[-v | --verbose] show[-n] {name}…​
		/// </summary>
		/// <param name="git"></param>
		/// <param name="folder"></param>
		/// <param name="remote"></param>
		/// <returns></returns>
		static public string Vw(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"-v show {remote}");


		}

		




	}
}
