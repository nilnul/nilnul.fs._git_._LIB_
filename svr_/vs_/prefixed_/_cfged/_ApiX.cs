﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs_.prefixed_._cfged
{
	/// <remarks>
	/// https://www.visualstudio.com/en-us/docs/integrate/api/overview
	/// </remarks>
	/// https://app.vssps.visualstudio.com/_apis/Accounts?[memberId={GUID}][&ownerId={GUID}]&api-version=1.0
	///https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
	///https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version={version}
	///curl -u {username}[:{personalaccesstoken}] https://{account}.VisualStudio.com/DefaultCollection/_apis/projects?api-version=2.0


	static public class _CfgedX
	{
		static public string Cfged => nilnul.fs.git.Properties.Settings.Default.svr_vs__prefix ?? throw new ArgumentNullException();

		static public string GenerateBaseUrl_noEndSlash(string account) {
			return vs_._PrefixedX.GenerateBaseUrl_noEndSlash(Cfged);
		}
		static public string GenerateBaseUrl_hasEndSlash(string account) {
			return $"{GenerateBaseUrl_noEndSlash(account)}/";
		}
		static public string GenerateUrl1_0(string areaResources, string version="1.0") {
			return vs_._PrefixedX.GenerateUrl1_0(Cfged,areaResources,version);
		}

		static public string GenerateUrl(string account,string areaResources, string version ) {
			return vs_._PrefixedX.GenerateUrl(Cfged,areaResources,version);
		}

		static public string GenerateUrl2_0preview(string areaResources ) {
			return vs_._PrefixedX.GenerateUrl2_0preview(Cfged,areaResources);
		}

		static public string GenerateUrl1_0preview(string account,string areaResources ) {
			return GenerateUrl(account,areaResources,"1.0-preview");
		}

		
	}
}