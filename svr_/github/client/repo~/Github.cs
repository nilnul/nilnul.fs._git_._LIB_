using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.client_
{
	/// <summary>
	/// header loaded from cfg;
	/// cred loaded from vault
	/// </summary>
	///
	[Obsolete(nameof(git.svr.client_.accVaulted_.Github))]

	public class Github 

		: nilnul.fs.git.ClientI
		//ISerializable
	{
		public string header;

		public string credKey =>nilnul.fs.git.svr_.Github.Singleton.host.ToString();

		public Github(string header)
		{
			this.header = header;
			_ini();

		}
		private string _username;
		public string username {
			get {
				return _username;
			}
		}


		void _ini() {
			gitHubClient = new GitHubClient(
				new ProductHeaderValue(this.header)
			);
			var saved = nilnul.win.app_._CredManX.Ensure(
				nilnul.fs.git.svr_.Github.Singleton.host.ToString()
			);
			if (saved == null)
			{
				throw new exception_.UnexpectedException("after ensurance,  the credential shall not be null.");
			}

			gitHubClient.Credentials = new Credentials( saved.UserName,saved.Password);

			_username = saved.UserName;
		}

		void _ini_withToken() {
			gitHubClient = new GitHubClient(
				new ProductHeaderValue(this.header)
			);
			var saved = nilnul.win.app_._CredManX.Ensure(
				nilnul.fs.git.svr_.Github.Singleton.host.ToString()
			);
			if (saved == null)
			{
				throw new exception_.UnexpectedException("after ensure the credential shall not be null.");
			}
			_username = saved.UserName;

			gitHubClient.Credentials = new Credentials( saved.Password);
		}


		[NonSerialized]
		public GitHubClient gitHubClient;



		protected Github()
		{

		}

		public Task<Repository> createRepo(string repo)
		{
			return gitHubClient.Repository.Create(
				new NewRepository(repo) { Private=true}
			);
		}

		public string gitUrl(string repo, string username)
		{
			return $"https://github.com/{username}/{repo}.git";
		}

		public string ensureRepo(string repo)
		{
			try
			{
				var repo11 = createRepo(
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
							return false;	//the exception will be rethrown
						}
					}
				);
				return gitUrl(repo,this.username);

			};
		}
	}
}
