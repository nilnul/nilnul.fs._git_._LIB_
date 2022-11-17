using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.repo.create_
{
	static public class _PersonalX
	{
		static public Task<Repository> Create(GitHubClient gitHubClient, string repo) {
			return gitHubClient.Repository.Create(
				new NewRepository(repo) { Private=true}
			);
		}
		public static string Ensure(GitHubClient gitHubClient,string repo)
		{
			try
			{
				var repo11 = Create(
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
					{ //* innerXpn: null;{Name = "ApiValidationException" FullName = "Octokit.ApiValidationException"};AssemblyQualifiedName: "Octokit.ApiValidationException, Octokit, Version=0.51.0.0, Culture=neutral, PublicKeyToken=085f320e4a727230";{"Repository creation failed."} */
						if (e is Octokit.RepositoryExistsException e2)
						{
							/// as the method is "ensure"
							//Debug.WriteLine($"{repo2create} already exists");
							return true; //the exception will be suppresed

						}
						else
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

		public static string Ensure(svr_.github.client_.Vaulted gitHubClient, string repo)
		{
			var c = gitHubClient.githubClient();

			return Ensure(c, repo);
		}
	}
}
