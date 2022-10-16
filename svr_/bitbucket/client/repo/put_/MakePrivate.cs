using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.client.repo.put_
{
	/// <summary>
	/// /rest/api/1.0/projects/{projectKey}/repos/{repositorySlug}
	/// </summary>
	static public class _MakePrivateX
	{
		public static string ByBasicUser_useWebRequest(NetworkCredential credential, string repo)
		{

			return ByBasicUser_useWebRequest(
				credential.UserName
				,credential.Password
				,
				repo
			);

		}

		static public string ByBasicUser_useWebRequest(string username, string password, string repoName)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create( repo._PutX.GetUrl(repoName));

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = nilnul.web.http._request.Method_.PUT;

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					is_private = false

				});

				streamWriter.Write(json);
				streamWriter.Flush();
				streamWriter.Close();

			}

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (
				var streamReader = new StreamReader(httpResponse.GetResponseStream())
			)
			{
				var result = streamReader.ReadToEnd();
				streamReader.Close();
				return result;
			}



		}



	}
}
