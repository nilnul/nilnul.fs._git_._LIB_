using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo
{
	static public class _UnlockX
	{
		static public void _ByRename_0depo(string repobase)
		{
			nilnul.fs.git.repo._UnlockX._ByRename_addressAssumeRepo(
				nilnul.fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(repobase)
			);
		}


		public static void _ByRename_0depo(FolderI en)
		{
			nilnul.fs.git.repo._UnlockX._ByRename(
				nilnul.fs.git.module._RepoX.DefaultFolder_assumeModule(en)
			);
		}



		public static void _ByRename(fs.folder_.git_.Module folder)
		{
			_ByRename_0depo(folder.ee);
		}

		static public void _ByRename(nilnul.fs.git.ModuleI repobase)
		{
			_ByRename_0depo(repobase.top1.en);
		}

	}
}
