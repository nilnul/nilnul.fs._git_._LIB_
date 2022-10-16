using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.vs.prjs.add
{
	public class ByWebClient_basicUser
	{

		private nilnul.fs.git.svr_.VisualStudio _svr;

		public nilnul.fs.git.svr_.VisualStudio svr
		{
			get { return _svr; }
			set { _svr = value; }
		}

		public ByWebClient_basicUser(
			nilnul.fs.git.svr_.VisualStudio vs	
		)
		{
			_svr = vs;
		}

		public string exe(string prjName, string version= "2.0-preview"){
			return Eval(
				_svr.account
				,
				_svr.credential.username
				,
				_svr.credential.password
				,
				prjName
				,
				version
			);
		}

		public string exe_errAsMsg(string prjName, string version= "2.0-preview"){
			try
			{
			return Eval(
				_svr.account
				,
				_svr.credential.username
				,
				_svr.credential.password
				,
				prjName
				,
				version
			);

			}
			catch (Exception e)
			{
				return e.Message;
				//throw;
			}
		}


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
							//""

							/*
							 测试名称:	VsGetProcesses
测试结果:	已通过
结果 的标准输出:	调试跟踪:
{"count":3,"value":[



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
