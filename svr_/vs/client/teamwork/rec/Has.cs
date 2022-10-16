using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.client.prjs.rec
{
	static public class _HasX
	{


		/*
		 GET https://{instance}/DefaultCollection/_apis/projects/{project}?api-version={version}[&includeCapabilities={boolean}&includeHistory={boolean}]

Parameter 	Type 	Default 	Notes
URL 			
instance 	string 		VS Team Services account ({account}.visualstudio.com) or TFS server ({server:port}).
project 	string 		Name or ID of the team project.
Query 			
api-version 	string 		Version of the API to use.
includeCapabilites 	boolean 	false 	Use true to include capabilities (such as source control) in the team project result.
includeHistory 	boolean 	false 	Use true to search within renamed projects that had such name in the past.
With capabilities

Get metadata on a team project, including its capabilities.
Sample request

GET https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/projects/Fabrikam-Fiber-TFVC?includeCapabilities=true&api-version=1.0

Sample response
Status code: 200

{
  "id": "eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
  "name": "Fabrikam-Fiber-TFVC",
  "url": "https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1",
  "description": "Team Foundation Version Control projects.",
  "state": "wellFormed",
  "capabilities": {
    "versioncontrol": {
      "sourceControlType": "Tfvc"
    },
    "processTemplate": {
      "templateName": "Microsoft Visual Studio Scrum 2013"
    }
  },
  "_links": {
    "self": {
      "href": "https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1"
    },
    "collection": {
      "href": "https://fabrikam-fiber-inc.visualstudio.com/_apis/projectCollections/d81542e4-cdfa-4333-b082-1ae2d6c3ad16"
    },
    "web": {
      "href": "https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/Fabrikam-Fiber-TFVC"
    }
  },
  "defaultTeam": {
    "id": "66df9be7-3586-467b-9c5f-425b29afedfd",
    "name": "Fabrikam-Fiber-TFVC Team",
    "url": "https://fabrikam-fiber-inc.visualstudio.com/DefaultCollection/_apis/projects/eb6e4656-77fc-42a1-9181-4c6d8e9da5d1/teams/66df9be7-3586-467b-9c5f-425b29afedfd"
  }
}

Sample code

    C# (GetProjectDetails method)

			 */
		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="prjName"></param>
		/// <param name="version"></param>
		/// <returns></returns>
		/// 

		static public bool Has(
				string account, string username, string password, string prjName, string version
			)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				Rec.GenerateUrl(account, prjName, version));

			//https://{instance}/DefaultCollection/_apis/projects/{project}?api-version={version}[&includeCapabilities={boolean}&includeHistory={boolean}]

			//httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = nilnul.web.http._request.Method_.GET;

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);



			try
			{
				HttpWebResponse httpResponse = null;
				try
				{
					httpResponse = (HttpWebResponse)(httpWebRequest.GetResponse());

				}
				catch (ArgumentNullException e)
				{
#if DEBUG
					//this is a bug in dot46.
#else
					throw e;
#endif
				}
				catch (WebException we)
				{
					var exceptionResponse = ((HttpWebResponse)(we.Response)).StatusCode;
					if (((HttpWebResponse)(we.Response)).StatusCode == HttpStatusCode.NotFound)
					{
						return false;
					}

					if (exceptionResponse == HttpStatusCode.Forbidden)
					{


					}

				}
				catch (Exception)
				{


					throw;
				}

				//var status = httpResponse.StatusCode;
				//if (status == HttpStatusCode.Forbidden)
				//{
				//	throw new UnauthorizedAccessException();
				//}
				//if (status == HttpStatusCode.NotFound)
				//{
				//	return false;
				//}
				return true;
			}

			catch (Exception)
			{

				throw;
			}








		}
	}
}
