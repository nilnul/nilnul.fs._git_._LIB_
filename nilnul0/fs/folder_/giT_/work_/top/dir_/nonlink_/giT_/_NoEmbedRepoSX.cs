using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.work_.top.dir_.nonlink_.giT_
{
	static public class _NoEmbedRepoSX
	{

		public static IEnumerable<DirI> _Dirs_assumeWorkbase(
			FolderI _top,
		nilnul.win.prog_.Git git = null)
		{
			if (nilnul.fs.folder.be_._NormalX.Be(_top) ) //for dir to be normal, parent must be normal
			{
				return nilnul.fs.folder_.nonlink_.giT_.work_.top.dir_.nonlink_.giT_._NoEmbedRepoSX._Dirs_assumeNonlinkWork(_top,git);

			}

			return new DirI[0];

			

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
