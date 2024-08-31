using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using nilnul.fs.git.svr_.azure.repo;

namespace nilnul.fs.git.svr_.azure.client.teamwork.create_
{
	[Obsolete("use viaLib instead")]
	static public class _PrjDefaultX
	{
		/// <summary>
		/// create project; and since every project has a default repo, the default repo is implicitly created.
		/// </summary>
		/// <param name="client"></param>
		/// <param name="prjName"></param>
		/// <param name="version"></param>
		/// <returns></returns>
		static public string Ret(
			Client client
			//string org,
			//string token
			,
			nilnul.fs.git.svr_.azure.repo.Name prjName
			,
			string version= _api.Version_.V6 // "2.0-preview"
		)
		{

			var prjsClient = new client.division_.Prjs(client);

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				prjsClient.url(version)
				//client._PrjsX.GenerateUrl(org, version)
			);

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = "POST";

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", "", client.token)
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

							{"id":"2bc","description":"This template is flexible and will work great for most teams using Agile planning methods, including those practicing Scrum.","isDefault":true,"type":"system","url":"https://t2.visualstudio.com/DefaultCollection/_apis/process/processes/adbc","name":"Agile"}]}

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


		static public string Ret(
			Client client
			//string org,
			//string token
			,
			string prjName
			,
			string version = _api.Version_.V6 // "2.0-preview"
		)
		{
			return Ret(client,  Name.ByEncode(prjName), version);
		}

		static public string Ret(
			string org,
			string token,
			nilnul.fs.git.svr_.azure.repo.Name prjName
			,
			string version= _api.Version_.V6
		)
		{


			return Ret(
				new Client(org,token),prjName,version
			);
		}


		public static string Ret(string cfged, Client client, Name prjName, string version = _api.Version_.V6)
		{
			return Ret(cfged, client.token,prjName,version);
		}

		




		static public string Ret_prjNameNotNormalized(
			string account
			,
			string password
			,
			string prjName,
			string version= _api.Version_.V6
		)
		{
			return Ret(account,  password, nilnul.fs.git.svr_.azure.repo.Name.ByEncode(prjName), version);
		}
	}
}
