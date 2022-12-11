using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo
{
	static public class _UnlockX
	{
		public const string LOCK_ENDING = repo.be_._LockenX.LOCK_ENDING;// ".lock";

		public static void _ByRename_assumeAddress(string  en)
		{
			new System.IO.DirectoryInfo(en).EnumerateFiles(en).Where( d=>d.Name.EndsWith(LOCK_ENDING)).Each(
				d=>
				nilnul.fs.file._RenameX.Rename(
					 d.FullName
					,
					$"{d}{nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.phrase()}"
				)
			);
		}
		public static void _ByRename(FolderI en)
		{
			nilnul.fs.folder._DocsX.Denotes(en).Where( d=>d.en.EndsWith(LOCK_ENDING)).Each(
				d=>
				nilnul.fs.file._RenameX.Rename(
					new nilnul.fs.address_.spear_.ParentDoc(en.address.en,d)
					,
					$"{d}{nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.phrase()}"
				)
			);
		}



		static public void _ByRename_assumeAddressAsFolder(string repobase) {
			 _ByRename( nilnul.fs.Folder.FroAddress(repobase));
		}

		public static void _ByRename(fs.folder_.git_.Repo folder)
		{
			 _ByRename(folder.en);
		}

		static public void _ByRename(nilnul.fs.git.RepoI repobase) {
			 _ByRename(repobase.folder);
		}

	}
}
