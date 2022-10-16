using nilnul.fs.git.client;
using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client_.vaulted_
{
	/// <summary>
	/// <seealso cref="nameof(fs.git.svr.client_.accVaulted_.Github)"/>
	/// </summary>
	///
	[Serializable]
	public class ForOrg
		:
		Vaulted
		,

		svr.client_.AccVaultedI

		//: ISerializable
	{

		/// <summary>
		/// eg:
		/// git:https://username1@github.com/org1
		/// </summary>
		/// <returns></returns>
		/// or shall we consider:
		///		nilnul-pub: 
		public override string vaultKey()
		{
			return $"{svr.client_._accVaulted.SettingsX.Prefix}https://{this.username}@{git.svr_.Github.Singleton.host}/{this.org}";
		}

		public nilnul.web.url_.SchemedNodewise url {
			get {
				return  web.url_.SchemedNodewise.Of_schemeOfNoColon_username_host_resource(
					"https"
					,
					
					this.username
							
							,
					git.svr_.Github.Singleton.host
					,
					$"/{this.org}"
					
				);
			}
		}

		private string _org;

		public string org
		{
			get { return _org; }
			set { _org = value; }
		}

		static public bool operator ==(ForOrg a, ForOrg b) {
			return (Vaulted)a == (Vaulted)b && a._org == b._org;
		}
		static public bool operator !=(ForOrg a, ForOrg b) {
			return !(a==b);
		}

		public ForOrg(string product, string username,string org0):base(product,username)
		{
			this._org = org0;
		}

		

		


		public ForOrg(Vaulted val, string org):this(val.header,val.username,org)
		{
		}

		/// <summary>
		/// required for serialization
		/// </summary>
		public ForOrg()
		{

		}

		public override GitHubClient githubClient()
		{
			var gitHubClient = new GitHubClient(
				new ProductHeaderValue(this.header)
			);

			var saved = nilnul.win.app_._CredManX.Ensure(
				vaultKey()
			);

			if (saved is null)
			{
				throw new exception_.UnexpectedException("after ensurance,  the credential shall not be null.");
			}

			gitHubClient.Credentials = new Credentials(saved.UserName, saved.Password);
	

			//_username = saved.UserName;
			return gitHubClient;
		}


		public string urn4ssh(nilnul.fs.git.svr.repo.Name name)
		{
			return (
				nilnul.fs.git.svr_.github.client.org.repo._UrlX.Ssh_withUsername(
					this.org
					,
					name.ToString()

				)
			)
			;


		}

	}
}
