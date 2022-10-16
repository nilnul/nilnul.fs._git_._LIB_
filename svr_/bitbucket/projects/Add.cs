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

namespace nilnul.dev.git.svr_.bitbucket.projects
{
	[Obsolete()]
	public class Add
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="prjName"></param>
		/// <returns></returns>
		static public string ByBasicUser_useWebRequest(string username, string password, string prjName)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(Projects.Url_1_0_);

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = "POST";

			httpWebRequest.Headers.Add("Authorization", 

				"Basic " +Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);

			

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					name = prjName
					
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
