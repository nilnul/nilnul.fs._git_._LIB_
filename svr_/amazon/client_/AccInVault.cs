using Amazon.CodeCommit;
using Amazon.Runtime;
using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.amazon.client_
{
	[Serializable]
	public class AccInVault :svr.client_.AccVaultedI

		//: ISerializable
	{
		/// <summary>
		/// per amazon documentation, client should use "AccessKeys" while https git should use httpsGitCrendentials.
		/// it's shared across different region.
		/// </summary>
		/// <param name="region"></param>
		/// <returns></returns>
		static public string VaultKey4push(string region)
		{
			return $"{svr.client_._accVaulted.SettingsX.Prefix}{git.svr_.amazon_._RegionX.Origion(region)}";
		}

		static public string VaultKey4client(string region)
		{
			return $"nilnul.dev.src.bak:{git.svr_.amazon_._RegionX.Origion(region)}";
			//return $"nilnul.dev.src.bak:{typeof( svr_.amazon.client_.AccInVault).FullName}";
		}

		/// <summary>
		/// github requires a header
		/// </summary>
		public string _region;
		public string region => _region;
		public string credKey4push =>VaultKey4push(_region);
		public string credKey4client =>VaultKey4client(_region);

		public AccInVault(string region)
		{
			this._region = region;
		}



		/// <summary>
		/// required for deserialization
		/// </summary>
		public AccInVault()
		{

		}

		/// public AmazonCodeCommitClient ensuredAmazonClient;
		 public AmazonCodeCommitClient genAmazonClient()
		{
			var saved = nilnul.win.app_._CredManX.Ensure(
				this.credKey4client
			);
			if (saved == null)
			{
				throw new exception_.UnexpectedException("after ensure the credential shall not be null.");
				return null;
			}
			return new AmazonCodeCommitClient(
				 new BasicAWSCredentials(
					 saved.UserName
					 ,
					 saved.Password
					)
				,
				 Amazon.RegionEndpoint.GetBySystemName(this.region)
				 //Amazon.RegionEndpoint.USEast2
			);
		}


		public string gitUrl(string repo)
		{
			return amazon_.region.repo._UrlX.Url(_region, repo);
		}

		public svr.ClientI genClient()
		{
			return this;
			//throw new NotImplementedException();
		}
	}
}
