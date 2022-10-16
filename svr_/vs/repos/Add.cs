using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.vs.repos
{
	public class Add
	{

		static public string Webclient_BasicUser(
	string account, string username, string password, string repoName, string prjId= "00000000-0000-0000-0000-000000000000"
)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				Repos.GenerateUrl1(account, "2.2"));

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
						name = repoName

					
						,projectId=""
					}

				);

				//json = new JavaScriptSerializer().Serialize(new
				//{
				//	name = prjName
				//});


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
