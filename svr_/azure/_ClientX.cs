using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.azure
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ClientX
	{
		static public VssConnection GetConn_0org(string org)
		{

			var keyName = nilnul.fs.git.svr_.azure._client._OrgX.Rsc(org);
			var personalAccessToken = nilnul.win.app_._CredManX.Get(keyName);

			String c_collectionUri = $"https://dev.azure.com/{org}";

			// Interactively ask the user for credentials, caching them so the user isn't constantly prompted
			VssCredentials creds = new VssBasicCredential(personalAccessToken.UserName, personalAccessToken.Password);// VssClientCredentials();


			//creds.Storage = new VssClientCredentialStorage();

			// Connect to Azure DevOps Services
			VssConnection connection = new VssConnection(new Uri(c_collectionUri), creds);
			return connection;

		}
	}
}
