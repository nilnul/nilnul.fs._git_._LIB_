using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.vs.client.prjs.add_
{
	public class ByWebClient_basicUser1
	{

		private nilnul.fs.git.svr_.vs.Client _client;

		public nilnul.fs.git.svr_.vs.Client client
		{
			get { return _client; }
			set { _client = value; }
		}

		public ByWebClient_basicUser1(
			nilnul.fs.git.svr_.vs.Client vs
		)
		{
			_client = vs;
		}

		public string ret_prjNameNotNormalized(
			string prjName
			,
			string version = "2.0-preview"
		)
		{
			return Ret_prjNameNotNormalized(
				_client.account
				,
				_client.credential.username
				,
				_client.credential.password
				,
				prjName
				,
				version
			);
		}

		public string ret(nilnul.fs.git.svr_.vs.repo.Name prjName, string version = "2.0-preview")
		{
			return Ret(
				_client.account
				,
				_client.credential.username
				,
				_client.credential.password
				,
				prjName
				,
				version
			);
		}

		public string result_prjNameNotNormalized(
			string prjName
			,
			string version = "2.0-preview"
		)
		{
			return result(
				nilnul.fs.git.svr_.vs.repo.Name.ByEncode(prjName)
				,
				version
			).ToString();
		}


		public nilnul._op.result_.explain_.RetTxt result(nilnul.fs.git.svr_.vs.repo.Name prjName, string version = "2.0-preview")
		{
			try
			{
				return new _op.result_.explain_.RetTxt(Ret(
					_client.account
					,
					_client.credential.username
					,
					_client.credential.password
					,
					prjName
					,
					version
				));

			}
			catch (Exception e)
			{
				return  _op.result_.explain_.RetTxt.FroXpn( e.ToString());
				//throw;
			}
		}

		static public string Ret(
			string account, string username, string password, nilnul.fs.git.svr_.vs.repo.Name prjName, string version
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
				string json = new JavaScriptSerializer().Serialize(new
				{
					name = prjName

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

							{"id":"bc","description":"This template is flexible and will work great for most teams using Agile planning methods, including those practicing Scrum.","isDefault":true,"type":"system","url":"https://t2.visualstudio.com/DefaultCollection/_apis/process/processes/ad6bc","name":"Agile"}]}

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


		static public string Ret_prjNameNotNormalized(
			string account, string username, string password, string prjName, string version
		)
		{
			return Ret(account, username, password, nilnul.fs.git.svr_.vs.repo.Name.ByEncode(prjName), version);
		}
	}
}
