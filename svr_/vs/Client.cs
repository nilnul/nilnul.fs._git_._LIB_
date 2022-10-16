using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs
{
	/// <remarks>
	/// https://www.visualstudio.com/en-us/docs/integrate/api/overview
	/// </remarks>
	/// https://app.vssps.visualstudio.com/_apis/Accounts?[memberId={GUID}][&ownerId={GUID}]&api-version=1.0
	///https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
	///https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version={version}
	///curl -u {username}[:{personalaccesstoken}] https://{account}.VisualStudio.com/DefaultCollection/_apis/projects?api-version=2.0


	public class Client:nilnul.fs.git.svr.ClientI
	{
		private string _account;
		public string account
		{
			get { return _account; }
			set { _account = value; }
		}

		private nilnul.web._credential.Slots _credential ;
		public nilnul.web._credential.Slots credential 
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Client(string account, nilnul.web._credential.Slots credential)
		{
			_account = account;
			_credential = credential;
		}


		public Client(string account, System.Net.NetworkCredential credential)
			:this(account,credential.UserName,credential.Password)
		{

		}

		public Client(string account, string username, string password)
		{
			_account = account;

			_credential = new web._credential.Slots(
				username
				,password
				
			);
		}

		public Client(string account,  string password)
			:this(account,"",password)
		{
			
		}


		/// <summary>
		/// this could be used in testing/personalTaskAutomation. The token is preset by a personalized acc/usr unitTest project.
		/// </summary>
		/// <param name="orgName"></param>
		/// <returns></returns>
		static public Client CreateFroVault(string orgName)
		{

			var url = nilnul.fs.git.svr_.vs._client._OrgX.Origin(orgName);

			var keyName = nilnul.fs.git.svr_.vs._client._OrgX.Rsc(orgName); ;

			var personalAccessToken = nilnul.win.app_._CredManX.Get(keyName);

			return new Client(orgName, personalAccessToken);// personalAccessToken.Password);
		}

		/// <summary>
		/// this could be used for testing or for personal use. The org is preset in EnvironmentVar by personal unit-testing project regarding acc/usr, as the environ var is for usr, not for process/temp, or for os/allUsers
		/// </summary>
		/// <returns></returns>
		static public Client CreateFroVault()
		{

			return CreateFroVault(
				 Environment.GetEnvironmentVariable(
					 "nilnul.fs.git.svr_.azure._client.Org1"
					 ,
					 EnvironmentVariableTarget.User
				 ) ?? throw new ArgumentNullException("env var is not set for the azure org")
			);
		}

		public string origin()
		{
			return _client._OrgX.Origin(this.account);
		}
		public string root()
		{
			return _client._OrgX.Root(origin());
		}

		/// <summary>
		/// The request URI, in the following form: VERB https://{instance}[/{team-project}]/_apis[/{area}]/{resource}?api-version={version}
		/// here we omitted the team-project
		/// </summary>
		/// <returns></returns>
		public string spear4apis()
		{
			return $"{root()}_apis";
		}
		public string stem4apis()
		{
			return $"{spear4apis()}/";
		}

		public VssConnection vssConnection()
		{


			return new VssConnection(
				new Uri(this.origin())
				//uriBase
				, new VssBasicCredential(
					this.credential.username
					,
					this.credential.password
				//"", this.token
			)

			);
		}


		[Obsolete()]
		static public string GenerateBaseUrl(string account) {

			return $"https://{account}.VisualStudio.com/DefaultCollection/";

		}
		static public string GenerateBaseUrl_noEndSlash(string account) {

			return $"https://{account}.VisualStudio.com/DefaultCollection";

		}
		static public string GenerateBaseUrl_hasEndSlash(string account) {

			return $"{GenerateBaseUrl_noEndSlash(account)}/";

		}
		static public string GenerateUrl1_0(string account,string areaResources, string version="1.0") {
			return $"https://{account}.VisualStudio.com/DefaultCollection/_apis/{areaResources}?api-version={version}";
		}

		static public string GenerateUrl(string account,string areaResources, string version ) {
			return $"https://{account}.VisualStudio.com/DefaultCollection/_apis/{areaResources}?api-version={version}";
		}

		static public string GenUrlWithPrj(string account,string project, string areaResources, string version) {

			return $"{GenerateBaseUrl_noEndSlash(account)}/{project}/_apis/{areaResources}?api-version={version}";


			//GET https://{instance}/DefaultCollection/[{project}]/_apis/git/repositories?api-version={version}


		}

		static public string GenerateUrl2_0preview(string account,string areaResources ) {
			return GenerateUrl1_0(account,areaResources,"2.0-preview");
		}


		static public string GenerateUrl1_0preview(string account,string areaResources ) {
			return GenerateUrl(account,areaResources,"1.0-preview");
		}

	}
}
