using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonlink_.giT_.work_.top.dir_.nonlink_.giT_
{
	static public class _NoEmbedRepoSX
	{

		public static IEnumerable<DirI> _Dirs_assumeNonlinkWork(FolderI _top_nonlink,
		nilnul.win.prog_.Git git = null)
		{

			return nilnul.fs.folder.dirs_._NonlinkX.Dirs(_top_nonlink).Where(
					child =>
					 nilnul.fs.folder.be_.giT_.repo_.embed.Anto.Ov(git).be(
						new nilnul.fs.address_.shield_.BaseDir(_top_nonlink.address.en, child)

					)


			);


		}
		public static IEnumerable<nilnul.fs._address.DirI> _Dirs_assumeNonlinkWork(
		nilnul.fs.address_.ShieldI _top_nonlink
		,
		nilnul.win.prog_.Git git = null
	)
		{

			return _Dirs_assumeNonlinkWork(
				new nilnul.fs.Folder(_top_nonlink)
				,
				git
			);
		}
	}

}
