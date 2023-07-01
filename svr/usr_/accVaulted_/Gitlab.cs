using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client_.accVaulted_
{
	/// <summary>
	/// <see cref="fs.git.svr_.gitlab.client_.AccInVault"/>
	/// </summary>
	[Serializable]
	public class Gitlab :svr.client_.accVaulted_.GitlabI

		//: ISerializable
	{
		/// <summary>
		/// </summary>
		private string _usr;
		public string usr {
			get { return _usr; }
			set { _usr = value; }
		}

		public string credKey4push =>nilnul.fs.git.svr_.gitlab.client_.AccInVault.CredKey(usr);

		public Gitlab(string acc)
		{
			this.usr = acc;
		}



		public Gitlab()
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
			return this;
		}
	}
}
