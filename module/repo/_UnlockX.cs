using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	static public class _UnlockX
	{
		public const string LOCK_ENDING = git.repo.be_._LockenX.LOCK_ENDING;// ".lock";
		static public void _ByRename_moduleAssumeAddress(string repobase)
		{
			nilnul.fs.git.repo._UnlockX._ByRename_addressAssumeRepo(
				nilnul.fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(repobase)
			);
		}


		public static void _ByRename_assumeModule(FolderI en)
		{
			nilnul.fs.git.repo._UnlockX._ByRename(
				nilnul.fs.git.module._RepoX.DefaultFolder_assumeModule(en)
			);
		}


		static public void _ByRename_moduleAssumeAddressAsFolder(string repobase)
		{
			_ByRename_assumeModule(nilnul.fs.Folder.FroAddress(repobase));
		}

		public static void _ByRename(fs.folder_.git_.Module folder)
		{
			_ByRename_assumeModule(folder.ee);
		}

		static public void _ByRename(nilnul.fs.git.ModuleI repobase)
		{
			_ByRename_assumeModule(repobase.top1.en);
		}

	}
}
