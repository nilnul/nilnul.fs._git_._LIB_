using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.client.noCred_
{
	[Serializable]
	[Obsolete(nameof(git.svr.client_.accVaulted_.Github))]
	public class Github :NoCredI

		//: ISerializable
	{
		public string header;

		public string credKey =>nilnul.fs.git.svr_.Github.Singleton.host.ToString();

		public Github(string header)
		{
			this.header = header;
		}

		public void ini() {
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

		public string gitUrl(string repo)
		{
			throw new NotImplementedException();
		}

		public ClientI genClient()
		{
			return new nilnul.fs.git.client_.Github(this.header);
		}
	}
}
