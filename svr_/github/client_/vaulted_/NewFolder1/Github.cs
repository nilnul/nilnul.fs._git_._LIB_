using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted_
{

	[Serializable]
	[Obsolete(nameof(fs.git.svr_.github.client_.Vaulted))]

	public class Github : svr.client_.AccVaultedI

	//: ISerializable
	{
		public string header;


		public string credKey4push => nilnul.fs.git.svr_.Github.Singleton.host.ToString();

		public Github(string header)
		{
			this.header = header;
		}

		public void ini()
		{
			gitHubClient = new GitHubClient(
				new ProductHeaderValue(this.header)
			);
		}



		[NonSerialized]
		public GitHubClient gitHubClient;



		public Github()
		{

		}

		//public string createRepo(string repo)
		//{
		//	gitHubClien

		//}

		public NetworkCredential cred()
		{
			return nilnul.win.app_._CredManX.Ensure(
							this.credKey4push
					);
		}

		public string gitUrl(string repo)
		{
			var saved = cred();
			return fs.git.svr_.github.client.repo._UrlX.Url(
				saved.UserName, repo
			);
			//throw new NotImplementedException();
		}

		public git.svr.ClientI genClient()
		{
			return new nilnul.fs.git.svr.client_.accVaulted_.Github(this.header);
		}
	}
}
