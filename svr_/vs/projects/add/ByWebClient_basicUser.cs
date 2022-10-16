using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.dev.git.svr_.vs.projects.add
{
	public class ByWebClient_basicUser
	{


		static public string Eval(
			string account, string username, string password, string prjName,string version
		)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				Projects.GenerateUrl1(account, version));

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
				string json = new JavaScriptSerializer().Serialize(new{
					name = prjName

					,
					description = "Frabrikam travel app for Windows Phone",
					capabilities = new
					{
						versioncontrol = new
						{
							sourceControlType = "Git"

						},
						processTemplate = new
						{
							templateTypeId = "adcc42ab-9882-485e-a3ed-7678f01f66bc"
							//"6b724908-ef14-45cf-84f8-768b5384da45"

							/*
							 测试名称:	VsGetProcesses
测试结果:	已通过
结果 的标准输出:	调试跟踪:
{"count":3,"value":[

							{"id":"2c","description":"This template is flexible and will work great for most teams using Agile planning methods, including those practicing Scrum.","isDefault":true,"type":"system","url":"https://t2.visualstudio.com/DefaultCollection/_apis/process/processes/ac","name":"Agile"}]}


							 */

						}
					}
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
