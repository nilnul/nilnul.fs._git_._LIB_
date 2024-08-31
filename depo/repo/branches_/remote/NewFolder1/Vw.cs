using nilnul.win.process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo.branches_.remote
{
	[Obsolete(nameof(nilnul.fs.git.module.repo.branches_.remote_.all._VwX),true)]
	static public class _VwX
	{



		/// <summary>
		///  -a shows all local and remote branches, while -r shows only remote branches.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_gitTop"></param>
		/// <returns></returns>
		static public IEnumerable<string> _Vw(nilnul.win.prog_.Git git, nilnul.fs.Folder _gitTop)
		{

			var result = nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(_gitTop, "branch -r");



			return result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

		}


		static public IEnumerable<string> _Vw( nilnul.fs.Folder _gitTop)
		{
			return _Vw(nilnul.win.prog_.Git.StaticInstance, _gitTop);
		}
	}
}
