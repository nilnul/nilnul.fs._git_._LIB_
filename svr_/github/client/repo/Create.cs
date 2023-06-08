using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.repo
{
	static public class _CreateX
	{
		static public Task<Repository> CreatePublic(GitHubClient gitHubClient, string repo) {
			return gitHubClient.Repository.Create(
				new NewRepository(repo) { Private=false}
			);
		}
		public static string EnsurePublic(svr_.github.client_.Vaulted gitHubClient, string repo)
		{
			var c = gitHubClient.githubClient();

			return EnsurePublic(c, repo);
		}

		public static string EnsurePublic(GitHubClient gitHubClient,string repo)
		{
			try
			{
				var repo11 = CreatePublic(
					gitHubClient,
					repo

				).Result;
				//Debug.WriteLine(repo);
				return repo11.CloneUrl;

			}
			catch (System.AggregateException ex)
			{
				ex.Flatten().Handle(
					e =>
					{
						if (e is Octokit.RepositoryExistsException e2)
						{
							//Debug.WriteLine($"{repo2create} already exists");
							return true; //the exception will be suppresed

						}
						else  // when using useranem and password, not token, the authentication is failed;
						{
							return false;   //the exception will be rethrown
						}
					}
				);
				return github.client.repo._UrlX.Url(
					gitHubClient.Credentials.Login
					,
					repo
					
				);

			};
		}

	}
}
