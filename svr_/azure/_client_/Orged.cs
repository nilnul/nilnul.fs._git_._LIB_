using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure._client_
{
	/// <remarks>
	/// https://www.visualstudio.com/en-us/docs/integrate/api/overview
	/// </remarks>
	/// https://app.vssps.visualstudio.com/_apis/Accounts?[memberId={GUID}][&ownerId={GUID}]&api-version=1.0
	///https://app.vssps.visualstudio.com/_apis/profile/profiles/me?api-version=1.0
	///https://{account}.VisualStudio.com/DefaultCollection/_apis[/{area}]/{resource}?api-version={version}
	///curl -u {username}[:{personalaccesstoken}] https://{account}.VisualStudio.com/DefaultCollection/_apis/projects?api-version=2.0


	static public class _OrgX
	{


		static public string Spear(string org)
		{
			return $"https://dev.azure.com/{org}";
		}
		static public string Stem(string org)
		{
			return $"{Spear(org)}/";
		}
		static public string Spear4api(
			string account
		)
		{
			return $"{Stem(account)}/_apis";
		}
		static public string Spear4collection(
			string account
		)
		{
			return $"{Stem(account)}/DefaultCollection";
		}

		static public string Stem4collection(
			string account
		)
		{
			return $"{Spear4collection(account)}/";
		}

		static public string Stem4api(
			string account
		)
		{
			return $"{Spear4api(account)}/";
		}
		/// <summary>
		/// for testing or personal use. The environ var can be preset by personal testing project regarding usr/acc
		/// </summary>
		/// <returns></returns>
		static public string FroEnv()
		{
			return Environment.GetEnvironmentVariable(
				"nilnul.fs.git.svr_.azure._client.Org"
				,
				EnvironmentVariableTarget.User
			)
			??
			throw new ArgumentNullException("env var is not set for the azure org");
		}

	}

}