using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client_
{
	/// <summary>
	/// <see cref="nameof(fs.git.svr.client_.accVaulted_.Github)"/>
	/// </summary>
	[Serializable]
	[Obsolete(nameof(Vaulted))]
	public class AccInVault :svr.client_.AccVaultedI

		//: ISerializable
	{
		static public string VaultKey()
		{
			return $"{svr.client_._accVaulted.SettingsX.Prefix}https://{git.svr_.Github.Singleton.host}";
		}
		/// <summary>
		/// github requires a header
		/// </summary>
		public string _header;



		public string credKey4push =>VaultKey();

		public string header => _header;

		public AccInVault(string header)
		{
			this._header = header;
		}




		public AccInVault()
		{

		}


		

		public string gitUrl(string repo)
		{
			return amazon_.region.repo._UrlX.Url(_header, repo);
		}

		public svr.ClientI genClient()
		{
			throw new NotImplementedException();
		}
	}
}
