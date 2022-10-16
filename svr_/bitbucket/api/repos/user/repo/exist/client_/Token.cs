using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.api.repos.user.repo.exist.client_
{
	public class Token
	{

		static public bool ByBasicUser_useWebRequest(string username, string password, string repo_slug)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(Repo.CreateUrl2_0_(username,repo_slug));

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = "POST";

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
					name = repo_slug

				});

				streamWriter.Write(json);
				streamWriter.Flush();
				streamWriter.Close();

			}

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			var status = httpResponse.StatusCode;
			if (status== HttpStatusCode.Forbidden)
			{
				throw new UnauthorizedAccessException();
			}
			if (status== HttpStatusCode.NotFound)
			{
				return false;
			}
			return true;

			//using (
			//	var streamReader = new StreamReader(httpResponse.GetResponseStream())
			//)
			//{
			//	var result = streamReader.ReadToEnd();
			//	streamReader.Close();
			//	return result;
			//}



		}

	}
}
