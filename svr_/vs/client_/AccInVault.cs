using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.client_
{
	[Serializable]
	public class AccInVault :svr.client_.accVaulted_.VsI //. AccVaultedI

		//: ISerializable
	{
		static public string VaultKey(string acc)
		{
			return $"{svr.client_._accVaulted.SettingsX.Prefix}https://{acc}.visualstudio.com";
		}
		/// <summary>
		/// github requires a header
		/// </summary>
		public string _prefix;



		public string credKey4push =>VaultKey(_prefix);

		public string prefix => _prefix;

		public AccInVault(string accName)
		{
			this._prefix = accName;
		}




		public AccInVault()
		{

		}



		/// <summary>
		/// assume not normalized
		/// </summary>
		/// <param name="repo"></param>
		/// <returns></returns>
		public string gitUrl(string repo)
		{
			return vs.client.repo._UrlX._Url(_prefix, repo);
		}

		public NetworkCredential cred0nul {
			get {
				return nilnul.win.app_._CredManX.Get(this.credKey4push) ;
			}
		}

		//[Obsolete("not implemented", true)]
		public svr_.vs.Client _genClient()
		{
			var cred = nilnul.win.app_._CredManX.Get(this.credKey4push) ;
			if (cred is null)
			{
				return new svr_.vs.Client(this.prefix,null as NetworkCredential);
			}
			else
			{
				return new svr_.vs.Client(this.prefix,cred);

			}
		}
		public svr.ClientI genClient()
		{
			return _genClient();
		}

		public svr_.vs.Client genOfficialClient()
		{
			return new Client(this._prefix, this.cred0nul?.Password);
		}


	}
}
