using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.vs.repos.add_.toPrj_
{
	public class ByWebClient_basicUser
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="account"></param>
		/// <param name="username"></param>
		/// <param name="password"></param>
		/// <param name="prjId">
		/// Name or ID team project. 
		/// </param>
		/// <param name="repoName"></param>
		/// <param name="version"></param>
		/// <returns></returns>

		static public string Eval(
			string account, string username, string password, string prjId,string repoName,string version
		)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				Repos.GenerateUrl1(account, version));

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
				string json = new JavaScriptSerializer().Serialize(
					new{
						name = repoName
						,
						project = new
						{
							id = prjId
						}
					}
				);



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
