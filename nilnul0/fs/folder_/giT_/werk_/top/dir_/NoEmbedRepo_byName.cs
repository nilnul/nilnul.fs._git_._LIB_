using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.dir_.giT_
{
	static public class _NoEmbedRepoS_byNameX
	{

		public static IEnumerable<DirI> _Dirs_assumeWorkbase(
			FolderI _top,
		nilnul.win.prog_.Git git = null)
		{

			return nilnul.fs.folder._DirsX.Dirs(_top).Where(
				child =>
					!nilnul.fs._address._dst.denote.Eq.Singleton.eq(
					child.denote
					,
					".git"
					)
			);

			


			

		}
		public static IEnumerable<nilnul.fs._address.DirI> _Dirs_assumeWorkbase(
		nilnul.fs.address_.ShieldI _top_nonlink
		,
		nilnul.win.prog_.Git git = null
	)
		{
			return _Dirs_assumeWorkbase( new nilnul.fs.Folder(_top_nonlink),git);
		}
	}

}
