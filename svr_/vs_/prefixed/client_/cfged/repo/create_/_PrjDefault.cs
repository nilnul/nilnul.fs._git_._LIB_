using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using nilnul.fs.git.svr_.vs.repo;

namespace nilnul.fs.git.svr_.vs_.prefixed.client_.cfged.repo.create_
{
	static public class _PrjDefaultX
	{
		static public string Ret(
			string prefix, string username, string password, nilnul.fs.git.svr_.vs.repo.Name prjName, string version= "2.0-preview"
		)
		{


			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				_prjs._ApiX.GenerateUrl(prefix, version));

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
					name = prjName.ToString()

					,
					description = "",
					capabilities = new
					{
						versioncontrol = new
						{
							sourceControlType = "Git"

						},
						processTemplate = new
						{
							templateTypeId = "adcc42ab-9882-485e-a3ed-7678f01f66bc"

							/*
							 测试名称:	VsGetProcesses
测试结果:	已通过
结果 的标准输出:	调试跟踪:
{"count":3,"value":[

							{"id":"2c","description":"This template is flexible and will work great for most teams using Agile planning methods, including those practicing Scrum.","isDefault":true,"type":"system","url":"https://t2.visualstudio.com/DefaultCollection/_apis/process/processes/ad66bc","name":"Agile"}]}

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


		public static string Ret(string cfged, Client client, Name prjName, string version)
		{
			return Ret(cfged, client.credential.username,client.credential.password,prjName,version);
		}

		static public string Ret(
			nilnul.fs.git.svr_.vs.repo.Name prjName, string version = "2.0-preview"
		)
		{
			return Ret(
				_PrefixedX.Cfged, client_._CfgedX.GetClient(), prjName,version
			);
		}




		static public string Ret_prjNameNotNormalized(
			string account, string username, string password, string prjName, string version
		)
		{
			return Ret(account, username, password, nilnul.fs.git.svr_.vs.repo.Name.ByEncode(prjName), version);
		}
	}
}
