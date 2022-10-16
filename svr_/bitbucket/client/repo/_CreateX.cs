using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bb.client.repo
{
	static public class _CreateX
	{

		static public string ByBasicUser_useWebRequest(nilnul.web._credential.Slots slot, string prjName)
		{

			return ByBasicUser_useWebRequest(slot.username, slot.password, prjName);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="prjName"></param>
		/// <returns></returns>
		static public string ByBasicUser_useWebRequest(string username, string password, string prjName)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(repos._ApiX.Url_1_0_);

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
					name = prjName  //verify that the name here can be not normalized
					,
					is_private = true

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
