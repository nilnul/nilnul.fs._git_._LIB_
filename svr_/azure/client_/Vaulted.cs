using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure.client_
{
	[Serializable]
	public class Vaulted :

		svr.client_.AccVaultedI//. AccVaultedI

		//: ISerializable
	{
		static public string VaultKey(string org)
		{
			return $"{svr.client_._accVaulted.SettingsX.Prefix}https://dev.azure.com/{org}";
		}




		public string credKey4push =>VaultKey(_org);

		/// <summary>
		/// para less ctor is required for deserialization
		/// </summary>
		public Vaulted()
		{

		}

		/// <summary>
		/// the organzation name.
		/// todo: for personal account, the org name is the personal account name. ?? /// todo : verification needed.
		/// </summary>
		public string _org;
		public string org => _org;

		public Vaulted(string prod0)
		{
			this._org = prod0;
		}






		public string gitUrl(string repo)
		{
			return azure.client.teamwork.repo_.Defaulted.Spear4git(_org, repo);
			//return vs.client.repo._UrlX._Gen(_org, repo);
		}

		public NetworkCredential cred0nul {
			get {
				return nilnul.win.app_._CredManX.Get(this.credKey4push) ;
			}
		}

		//[Obsolete("not implemented", true)]
		public svr_.azure.client_.Vaulted _genClient()
		{
			return this;
			//var cred = nilnul.win.app_._CredManX.Get(this.credKey4push) ;
			//if (cred is null)
			//{
			//	return new svr_.azure.Client(this.org,null);
			//}
			//else
			//{
			//	return new svr_.azure.Client(this.org,cred);

			//}
		}
		public svr.ClientI genClient()
		{
			return _genClient();
		}

		public svr_.azure.Client genAzureClient()
		{
			return new Client(this._org, this.cred0nul?.Password);
		}

		static public svr_.azure.Client Client(Vaulted vaulted) {
			return new Client(
				vaulted.org,vaulted.cred0nul?.Password
			);
		}

		static public Vaulted Client(svr_.azure.Client vaulted) {
			return new Vaulted(
				vaulted.org
			);
		}



	}
}
