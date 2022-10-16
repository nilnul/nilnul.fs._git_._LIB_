using System;

namespace nilnul.fs.git.svr_.gitlab.client.repo
{
	static public class _UrlX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="usr"></param>
		/// <param name="repoName">assume normed</param>
		/// <returns></returns>
		///
		static public string _Gen_repoAssumeNormed(string usr, string repoName)
		{
			return $"https://gitlab.com/{usr}/{repoName}.git";
		}

		static public string _Gen_repoAssumeNormed(string usr, nilnul.fs.git.svr.repo.Name repoName)
		{
			return _Gen_repoAssumeNormed(usr, repoName.ToString());
		}

		static public string Gen(string usr, gitlab.repo.Name repoName)
		{
			return _Gen_repoAssumeNormed(usr, repoName.ToString());
			//return $"https://gitlab.com/{usr}/{repoName}.git";
		}


		/// <summary>
		/// <summary>
		/// 
		/// </summary>
		/// <param name="usr"></param>
		/// <param name="repoName">assume unnormed</param>
		/// <returns></returns>
		///
		static public string _Gen_repoAssumeUnnormed(string usr, string repoName)
		{
			return _Gen_repoAssumeNormed(
				usr, gitlab.repo._NameX.Encode(repoName)
			);
		}
		static public string _Gen_repoAssumeUnnormed(string usr, nilnul.fs.git.svr.repo.Name repoName)
		{
			return _Gen_repoAssumeUnnormed(
				usr
				,
				repoName.ToString()
			);
		}

		/// 
		/// </summary>
		/// <param name="usr"></param>
		/// <param name="repoName">assume unnormed</param>
		/// <returns></returns>
		///

		[Obsolete(nameof(_Gen_repoAssumeUnnormed))]
		static public string Gen(string usr, nilnul.fs.git.svr.repo.Name repoName)
		{
			return _Gen_repoAssumeUnnormed(usr,repoName);
			//return $"https://gitlab.com/{usr}/{repoName}.git";
		}



		/// <summary>
		/// assume name is normed.
		/// </summary>
		/// <param name="accName"></param>
		/// <param name="repo"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(_Gen_repoAssumeUnnormed))]
		public static string Gen(string accName, string repo)
		{
			return _Gen_repoAssumeUnnormed(accName, new svr.repo.Name(repo) );
		}
	

	}



}
