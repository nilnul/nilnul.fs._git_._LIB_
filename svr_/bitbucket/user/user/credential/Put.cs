using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net;
using System.IO;

namespace nilnul.dev.git.svr_.bitbucket.user.credential
{
	public class Update
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="prjName"></param>
		/// <returns></returns>
		/// <remarks>
		/// https://developer.atlassian.com/static/rest/bitbucket-server/4.9.1/bitbucket-rest.html#idp1103408
		/// </remarks>
		static public string ByBasicUser_useWebRequest(string username, string password, string newPass)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(user.Credential.url);

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = "PUT";

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
					password = newPass
					,
					passwordConfirm=newPass
					,
					oldPassword=password

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
