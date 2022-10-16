using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir.be_.giT_
{
	static public class _ManableX
	{
		static public bool Be(nilnul.fs.folder_.ParentDir  _folderDir, nilnul.win.prog_.Git git=null) {

			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(_folderDir.en.parent, git) )
			{
				case categorize_.git_._plainWorkRepo.Ret.Plain:
					return true;
				case categorize_.git_._plainWorkRepo.Ret.Work:

					return nilnul.fs.folder_.giT_.work.dir.be_._NoEmbedRepoSX._Be_assumeParentIsWork( _folderDir, git);

				case categorize_.git_._plainWorkRepo.Ret.Repo:
					return false;

				default:
					throw new UnexpectedReachException();
					break;
			}
		}

		public static bool Be(ShieldI nonLink, DirI d, Git git=null)
		{
			return Be(
				new folder_.ParentDir(nonLink,d)
				,git
			);
		}
	}
}
