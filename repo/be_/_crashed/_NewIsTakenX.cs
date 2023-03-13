using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.be_._crashed
{
	/// <summary>
	/// such as:
	///		.git/packed-refs.new
	/// </summary>
	static public class _NewIsTakenX
	{

		public const string _EXT_ENDING = ".new";


		static public bool _Be_ofSpear(string s)
		{
			return s.EndsWith(_EXT_ENDING);
		}

		/// <param name="s"></param>
		/// <returns></returns>
		static public bool _Be_ofDoc(string s)
		{
			return s.EndsWith(_EXT_ENDING);
		}

		public static bool __Be_assumeRepobase(FolderI en)
		{
			return nilnul.fs.folder._DocsX.Denotes(en).Any(d => d.en.EndsWith(_EXT_ENDING));
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
