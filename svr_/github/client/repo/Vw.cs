using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.repo
{
	/// <summary>
	/// get the creation time of a repo;
	/// </summary>
	/// <remarks>
	/// Note the 1st commit's time might be earlier than this;
	/// </remarks>
	static public class _VwX
	{
		/// <summary>
		/// created_at
		/// </summary>
		/// <param name="gitHubClient"></param>
		/// <param name="owner"></param>
		/// <param name="repo"></param>
		/// <returns></returns>
		static public Task<Repository> VwAsTask(GitHubClient gitHubClient,string owner, string repo)
		{
			return gitHubClient.Repository.Get(
				owner
				,
				repo
			);
		}

		static public Repository Vw(GitHubClient gitHubClient,string owner, string repo)
		{
			return VwAsTask(gitHubClient,owner,repo).Result;
		}


	}
}
