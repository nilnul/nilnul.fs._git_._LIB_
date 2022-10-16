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
	/// <seealso cref="nameof(fs.git.svr.client_.accVaulted_.Github)"/>
	/// </summary>
	/// <exception cref="">
	///
	/// when doing some action such as creating repo, the connection might fail due to network blockage and an exception will be thrown.
	/// </exception>
	///
	[Serializable]
	public class Vaulted :svr.client_.AccVaultedI

		//: ISerializable
	{
		public const string HEADER = "git";
		public virtual string vaultKey()
		{
			return $"{_prod}:https://{this._username}@{git.svr_.Github.Singleton.host}";
		}

		/// <summary>
		/// github requires a header; you can provide a random value, such as "header"
		/// </summary>
		private string _prod=HEADER;

		//public string header => _header;

		[Obsolete(nameof(prod))]
		public string header {
			get {
				return _prod;
			}
			set {
				_prod = value;
			}
		}
		public string prod {
			get {
				return _prod;
			}
			set {
				_prod = value;
			}
		}


		private string _username;
		public string username
		{
			get
			{
				return _username;
			}
			set {
				_username = value;
			}
		}



		public string credKey4push =>vaultKey();

		static public bool operator ==(Vaulted a, Vaulted b) {
			return object.ReferenceEquals(a,b)
				||
				( a._prod == b._prod && a._username == b._username );
		}
		static public bool operator !=(Vaulted a, Vaulted b) {
			return !(a==b);
		}

		public Vaulted(string header, string username)
		{
			this._prod = header;
			this._username = username;
		}

		public Vaulted( string username):this(HEADER,username)
		{
			//this._username = username;
		}

		/// <summary>
		/// required for serialization
		/// </summary>
		public Vaulted()
		{

		}

		/// <summary>
		/// <see cref="Of"/>
		/// </summary>
		/// <param name="github"></param>
		public Vaulted(svr.client_.accVaulted_.Github github):this(
			github.header,github.cred().UserName
			
		)
		{
		}

		static public Vaulted Of(
			svr.client_.accVaulted_.Github

			github) {

			return new  Vaulted(

				github.header
				,
				github.cred().UserName
			);
		}

	public virtual GitHubClient githubClient() {
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

			gitHubClient.Credentials = new Credentials( saved.UserName,saved.Password);

			//_username = saved.UserName;
			return gitHubClient;
		}

		

		public string gitUrl(string repo)
		{
			return github.client.repo._UrlX.Url(_username, repo);
		}
		public string urn(string repo)
		{
			return _urn4ssh_assumeRepo(repo);
			//return github.client.repo._UrlX.Url(_username, repo);
			//return github.client.repo._UrlX.Url(_username, repo);
		}

		public string _urn4ssh_assumeRepo(string name)
		{
			return nilnul.fs.git.svr_.github.client.org.repo._UrlX.Ssh_withUsername(
				this.username
				,
				name
			);
		}

		public string urn4ssh(nilnul.fs.git.svr.repo.Name name)
		{
			return _urn4ssh_assumeRepo(
				name.ToString()
			);

			//return (
			//	nilnul.fs.git.svr_.github.client.org.repo._UrlX.Ssh_withUsername(
			//		this.username
			//		,
			//		name.ToString()

			//	)
			//);
		}


		public svr.ClientI genClient()
		{
			return this;
		}
	}
}
