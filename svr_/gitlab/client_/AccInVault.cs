using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.client_
{
	[Serializable]
	public class AccInVault :svr.client_.accVaulted_.GitlabI //. AccVaultedI

		//: ISerializable
	{
		/// <summary>
		/// github requires a header
		/// </summary>
		public string accName;

		static public string CredKey(string acc) {
			return svr_.gitlab._ClientX.VaultKey(acc);
		}

		public string credKey4push =>svr_.gitlab._ClientX.VaultKey(accName);

		public string getToken() {

			var saved = nilnul.win.app_._CredManX.Ensure(
				this.credKey4push
			);
			if (saved is null)
			{
				throw new exception_.UnexpectedException("after ensure the credential shall not be null.");
				return null;
			}
			return saved.Password;
		}

		public string usr => accName;

		public AccInVault(string accName)
		{
			this.accName = accName;
		}




		public AccInVault()
		{

		}



		/// <summary>
		/// assume Name is normalized.
		/// </summary>
		/// <param name="repo"></param>
		/// <returns></returns>
		public string gitUrl(string repo)
		{
			return gitlab.client.repo._UrlX._Gen_repoAssumeUnnormed(accName, repo);
		}

		public svr.ClientI genClient()
		{
			return this;
			//throw new NotImplementedException();
		}
	}
}
