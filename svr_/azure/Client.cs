using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure
{
	/// <remarks>
	/// https://www.visualstudio.com/en-us/docs/integrate/api/overview
	/// </remarks>
	/// https://app.vssps.visualstudio.com/_apis/Accounts?[memberId={GUID}][&ownerId={GUID}]&api-version=1.0
	///https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
	///https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version={version}
	///curl -u {username}[:{personalaccesstoken}] https://{account}.VisualStudio.com/DefaultCollection/_apis/projects?api-version=2.0



	public class Client

	{
		private string _org;

		public string org
		{
			get { return _org; }
			set { _org = value; }
		}

		private string _token;

		/// <summary>
		/// for client, username can be empty; for git.exe, such as "git push", the username cannot be empty and you can provide anything but empty string.
		/// </summary>
		public string token
		{
			get { return _token; }
			set { _token = value; }
		}


		public Client(string org0, string token0)
		{
			_org = org0;
			_token = token0;
		}

		public string spear()
		{
			return _client._OrgX.Spear(_org);
		}
		public string stem()
		{
			return _client._OrgX.Stem(_org);
		}
		public static object Stem(string org)
		{
			return _client._OrgX.Stem(org);

		}

		/// <summary>
		/// The request URI, in the following form: VERB https://{instance}[/{team-project}]/_apis[/{area}]/{resource}?api-version={version}
		/// here we omitted the team-project
		/// </summary>
		/// <returns></returns>
		public string spear4apis()
		{
			return $"{stem()}_apis";
		}
		public string stem4apis()
		{
			return $"{spear4apis()}/";
		}

		public VssConnection vssConnection()
		{


			return new VssConnection(
				new Uri(this.spear())
				//uriBase
				, new VssBasicCredential(
				"", this.token
			)

			);
		}

		/// <summary>
		/// this could be used in testing/personalTaskAutomation. The token is preset by a personalized acc/usr unitTest project.
		/// </summary>
		/// <param name="orgName"></param>
		/// <returns></returns>
		static public Client CreateFroVault(string orgName)
		{

			var url = nilnul.fs.git.svr_.azure._client._OrgX.Spear(orgName);

			var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(orgName); ;

			var personalAccessToken = nilnul.win.app_._CredManX.Get(keyName);

			return new Client(orgName, personalAccessToken.Password);
		}

		/// <summary>
		/// this could be used for testing or for personal use. The org is preset in EnvironmentVar by personal unit-testing project regarding acc/usr, as the environ var is for usr, not for process/temp, or for os/allUsers
		/// </summary>
		/// <returns></returns>
		static public Client CreateFroVault()
		{

			return CreateFroVault(
				 Environment.GetEnvironmentVariable("nilnul.fs.git.svr_.azure._client.Org"
				 ,
				  EnvironmentVariableTarget.User
				 ) ?? throw new ArgumentNullException("env var is not set for the azure org")
			);
		}





	}
}