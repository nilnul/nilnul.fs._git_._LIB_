using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.org.repo
{
	static public class _CreateX
	{
		static public Task<Repository> CreatePublic(GitHubClient gitHubClient, string org, string repo)
		{
			return gitHubClient.Repository.Create(
				org,
				new NewRepository(repo) { Private = false }
			);
		}
		public static string EnsurePublic(svr_.github.client_.Vaulted gitHubClient, string org, string repo)
		{
			var c = gitHubClient.githubClient();

			return EnsurePublic(c, org, repo);
		}

		public static string EnsurePublic(GitHubClient gitHubClient, string org, string repo)
		{
			try
			{
				var repo11 = CreatePublic(
					gitHubClient,
					org
					,
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
						else
						{
							/// the xpn changed and cannot be caught.
							///
							return true;
							return false;   //the exception will be rethrown
						}
					}
				);
				return github.client.org.repo._UrlX.Ssh_withUsername(
					org
					//,
					//gitHubClient.Credentials.Login
					,
					repo

				);
				return github.client.org.repo._UrlX.Url_withUsername(
					org,
					gitHubClient.Credentials.Login
					,
					repo

				);

			}
			catch (Exception ex)
			{
				throw;

				return github.client.org.repo._UrlX.Url_withUsername(
					org,
					gitHubClient.Credentials.Login
					,
					repo

				);


			}
			finally
			{

			}
		}

	}
}
