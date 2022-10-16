using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.giT_.work.dir.be_
{
	/// <summary>
	/// not including self
	/// </summary>
	static public class _NoEmbedRepoSX
	{

		public static bool _Be_assumeWork(address_.ShieldI work, nilnul.fs._address.DirI dir, win.prog_.Git git=null)
		{

			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(work,git))
			{
				return nilnul.fs.folder_.giT_.work_.top.dir.be_._NoEmbedRepoS_byNameX._Be_assumeDirIsWorkbaseChild(
					
					dir
				);
			}
			else
			{
				return nilnul.fs.folder_.giT_.work_.nontop.dir.be_._NoEmbedRepoSX.Be();
			}

		}

		public static bool _Be_assumeParentIsWork(BaseDir en, Git git=null)
		{
			return _Be_assumeWork(en.parent, en.child, git);
		}
		public static bool _Be_assumeParentIsWork(ParentDir folderDir, win.prog_.Git git=null)
		{
			return _Be_assumeParentIsWork(folderDir.en,git);

		}


		static public bool Be(
			nilnul.fs.folder_.git_.Work work
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Be_assumeWork(
				work.en.address.en
				,
				dir
				,
				git);

		}
	}
}
