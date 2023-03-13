using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.be_
{
	/// <summary>
	/// due to being crashed/etc;
	/// </summary>
	static public class _FsAccessIssueX
	{


		static public bool _Be_ofSpear(string s)
		{
			return s.EndsWith(_LockenX.LOCK_ENDING) || s.EndsWith(_crashed._NewIsTakenX._EXT_ENDING);
		}

		/// <param name="s"></param>
		/// <returns></returns>
		static public bool _Be_ofDoc(string s)
		{
			return s.EndsWith(_LockenX.LOCK_ENDING) || s.EndsWith(_crashed._NewIsTakenX._EXT_ENDING);
		}

		public static bool __Be_assumeRepobase(FolderI en)
		{
			return nilnul.fs.folder._DocsX.Denotes(en).Any(d => _Be_ofDoc(d));
		}

		static public bool _Be_assumeRepoAddress(string repobase)
		{
			return __Be_assumeRepobase(nilnul.fs.Folder.FroAddress(repobase));
		}

		public static bool Be(fs.folder_.git_.Repo folder)
		{
			return __Be_assumeRepobase(folder.en);
		}

		static public bool Be(nilnul.fs.git.RepoI repobase)
		{
			return Be(repobase.folder);
		}

	}
}

