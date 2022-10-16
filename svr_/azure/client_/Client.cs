using System;
using System.Collections.Generic;
using System.Linq;
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


	public class Client:nilnul.fs.git.svr.ClientI
	{
		private string _org;
		public string org
		{
			get { return _org; }
			set { _org = value; }
		}

		private nilnul.web._credential.Slots _credential ;
		public nilnul.web._credential.Slots credential 
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Client(string org0, nilnul.web._credential.Slots credential)
		{
			_org = org0;
			_credential = credential;
		}

		public Client(string org0, System.Net.NetworkCredential credential)
			:this(org0,credential.UserName,credential.Password)
		{

		}

		public Client(string org0, string username, string password)
		{
			_org = org0;

			_credential = new web._credential.Slots(
				username
				,password
				
			);
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
