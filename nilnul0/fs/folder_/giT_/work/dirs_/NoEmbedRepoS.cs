using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.giT_.work.dirs_
{
	/// <summary>
	/// not including self
	/// </summary>
	static public class _NoEmbedRepoSX
	{

		public static IEnumerable<DirI> _Dirs(address_.ShieldI work, win.prog_.Git git=null)
		{

			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(work,git))
			{
				return nilnul.fs.folder_.giT_.work_.top.dir_.giT_._NoEmbedRepoSX._Dirs_assumeWorkbase(work,git);
			}
			else
			{
				return nilnul.fs.folder_.giT_.work_.nontop.dir_._NoEmbedRepoSX._Dirs_assumeNontop(work);
			}


		}
		static public IEnumerable<nilnul.fs._address.DirI> Dirs(
			nilnul.fs.folder_.git_.Work work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Dirs(work.en.address.en,git);

		}
	}
}
