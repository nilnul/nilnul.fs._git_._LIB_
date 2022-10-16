using nilnul.fs.git.svr_.vs.client_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs_.prefixed
{
	/// <remarks>
	/// https://www.visualstudio.com/en-us/docs/integrate/api/overview
	/// </remarks>
	/// https://app.vssps.visualstudio.com/_apis/Accounts?[memberId={GUID}][&ownerId={GUID}]&api-version=1.0
	///https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
	///https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version={version}
	///curl -u {username}[:{personalaccesstoken}] https://{account}.VisualStudio.com/DefaultCollection/_apis/projects?api-version=2.0


	[Obsolete(nameof(vs.client_.AccInVault))]
	public class Client:nilnul.fs.git.svr.ClientI
	{


		private nilnul.web._credential.Slots _credential ;
		public nilnul.web._credential.Slots credential 
		{
			get { return _credential; }
			set { _credential = value; }
		}

		public Client( nilnul.web._credential.Slots credential)
		{
			_credential = credential;
		}

		public Client(System.Net.NetworkCredential credential)
			:this(credential.UserName,credential.Password)
		{

		}

		public Client( string username, string password)
			:this( new web._credential.Slots(username,password))
		{

			
		}

		
		[Obsolete(nameof(_PrefixedX))]
		static public string GenerateBaseUrl_noEndSlash(string account) {

			return $"https://{account}.VisualStudio.com/DefaultCollection";

		}
		[Obsolete(nameof(_PrefixedX))]

		static public string GenerateBaseUrl_hasEndSlash(string account) {

			return $"{GenerateBaseUrl_noEndSlash(account)}/";

		}
		[Obsolete(nameof(_PrefixedX))]

		static public string GenerateUrl1_0(string account,string areaResources, string version="1.0") {
			return $"https://{account}.VisualStudio.com/DefaultCollection/_apis/{areaResources}?api-version={version}";
		}
		[Obsolete(nameof(_PrefixedX))]

		static public string GenerateUrl(string account,string areaResources, string version ) {
			return $"https://{account}.VisualStudio.com/DefaultCollection/_apis/{areaResources}?api-version={version}";
		}
		[Obsolete(nameof(_PrefixedX))]

		static public string GenUrlWithPrj(string account,string project, string areaResources, string version) {

			return $"{GenerateBaseUrl_noEndSlash(account)}/{project}/_apis/{areaResources}?api-version={version}";



		}
		[Obsolete(nameof(_PrefixedX))]

		static public string GenerateUrl2_0preview(string account,string areaResources ) {
			return GenerateUrl1_0(account,areaResources,"2.0-preview");
		}

		[Obsolete(nameof(_PrefixedX))]

		static public string GenerateUrl1_0preview(string account,string areaResources ) {
			return GenerateUrl(account,areaResources,"1.0-preview");
		}

		internal static Client Of(AccInVault client)
		{
			var cred = client.cred0nul;
			if (cred is null)
			{
				throw new ArgumentNullException($"client {client} 's credential is null");
			}
			return new Client(
				client.cred0nul

			);
			//throw new NotImplementedException();
		}
	}
}
