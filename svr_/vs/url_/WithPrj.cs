using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.url_
{
	/// <remarks>
	/// https://www.visualstudio.com/en-us/docs/integrate/api/overview
	/// </remarks>
	/// https://app.vssps.visualstudio.com/_apis/Accounts?[memberId={GUID}][&ownerId={GUID}]&api-version=1.0
	///https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
	///https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version={version}
	///curl -u {username}[:{personalaccesstoken}] https://{account}.VisualStudio.com/DefaultCollection/_apis/projects?api-version=2.0


	public class WithPrj
	{
		
		
		

		

		static public string GenUrlWithPrj(string account,string project, string areaResources, string version) {

			return $"{Url.GenerateBaseUrl_noEndSlash(account)}/{project}/_apis/{areaResources}?api-version={version}";


			//GET https://{instance}/DefaultCollection/[{project}]/_apis/git/repositories?api-version={version}


		}



		static public string GenerateUrl2_0preview(string account,string prj,string areaResources ) {
			return GenUrlWithPrj(account,prj,areaResources,"2.0-preview");
		}


		static public string GenerateUrl1_0preview(string account,string prj,string areaResources ) {
			return GenUrlWithPrj(account,prj,areaResources,"1.0-preview");
		}

		static public string GenerateUrl1_0(string account,string prj,string areaResources ) {
			return GenUrlWithPrj(account,prj,areaResources,Url.Ver1_0);
		}


	}
}
