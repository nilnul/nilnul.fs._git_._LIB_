using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.be_
{
	/// <summary>
	/// locked by, eg:
	///		git.exe push --all --set-upstream --progress "nilnulBak_all33"
	///		,during the process of "set up to track"
	/// </summary>
	static public class _LockenX
	{


		public const string LOCK_ENDING = ".lock";

		static public bool _Be_ofSpear(string s) {
			return s.EndsWith(LOCK_ENDING);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s">
		///
		/// </param>
		/// <returns></returns>
		static public bool _Be_ofDoc(string s) {
			return s.EndsWith(LOCK_ENDING);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_denotation">
		/// eg:
		///		index.lock
		///		packed-refs.lock
		///		refs/heads/master.lock
		///			, the content of this file is the hash of the commit, and may vary to master (with no '.lock');
		///	eg:
		///		objects/pack/*.lock
		///		objects/pack/pack_git2_??idx.lock
		///	eg:
		///		.git/packed-refs.new
		///			,may prevent reference update after crash ?
		///		:
		///		Rename from 'D:/1(Git/.git/packed-refs.new' to 'D:/1(Git/.git/packed-refs' failed. Should I try again? (y/n) 
		///	eg:
		///		https://git-scm.com/docs/git-index-pack/2.29.0
		///		a .keep file used as a lock to prevent the race with git repack
		/// </param>
		/// <returns></returns>
		static public bool _Be_0denotation(string _denotation) {
			return _denotation.EndsWith(LOCK_ENDING);
		}

		static public bool _Be_0path(string _denotation) {
			return _denotation.EndsWith(LOCK_ENDING);
		}

		static public bool _Be_assumeRepoAddress(string repobase) {

			/// todo: enumerate recursively? at some cost of time.
			return System.IO.Directory.EnumerateFiles(repobase).Any( d=>d.EndsWith(LOCK_ENDING));
			// here, for now, we don't take in account for the objects/pack/, as that might be a pack issue. and we need to further investigate the occasion that would have an impact;

			//return __Be_assumeRepobase( nilnul.fs.Folder.FroAddress(repobase));
		}

		public static bool __Be_assumeRepobase(FolderI en)
		{
			return _Be_assumeRepoAddress(en.address.en.ToString());
			//return nilnul.fs.folder._DocsX.Denotes(en).Any( d=>d.en.EndsWith(LOCK_ENDING));
		}


		public static bool Be(fs.folder_.git_.Repo folder)
		{
			return __Be_assumeRepobase(folder.en);
		}

		static public bool Be(nilnul.fs.git.RepoI repobase) {
			return Be(repobase.folder);
		}

	}
}
