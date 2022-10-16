using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.dev.git.svr_.vs.prj.work.create
{
	public class ByWebClient_basicUser
	{

		public const string DESCRIPTION_PATH = "/fields/System.Description";
		public const string TITLE_PATH = "/fields/System.Title";

		static public string Eval(
			string account, string username, string password, string prjName,string version
			,string path, string val
		)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				work.Url.Gen_v10(account, prjName, work.WorkType.TASK));

			httpWebRequest.ContentType = "application/json-patch+json";

			httpWebRequest.Method = nilnul.web.http.Method.PATCH;

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);



			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new[]{
					new {
						op="add"

						,
						path= path ,//"/fields/System.Title"
						value= val//"JavaScript implementation for Microsoft Account"


					}
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

static public string Exe_twoFields(
			string account, string username, string password, string prjName,string version
			,string path, string val, string path1,string val1
		)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(
				work.Url.Gen_v10(account,prjName, work.WorkType.TASK));

			httpWebRequest.ContentType = "application/json-patch+json";

			httpWebRequest.Method = nilnul.web.http.Method.PATCH;

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);



			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new[]{
					new {
						op="add"

						,
						path= path ,//"/fields/System.Title"
						value= val//"JavaScript implementation for Microsoft Account"


					}
					,

					new {
						op="add"

						,
						path= path1 ,//"/fields/System.Title"
						value= val1//"JavaScript implementation for Microsoft Account"

					}
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

		static public string Create_withTitle(
			string account, string username, string password, string prjName, string version
			,    string val
		)
		{

			return Eval(account,username,password,prjName, version, "/fields/System.Title",  val);
		}

static public string Create_withDescription(
			string account, string username, string password, string prjName, string version
			,  string val
		)
		{

			return Eval(account,username,password,prjName, version, DESCRIPTION_PATH,  val);
		}
		static public string Create_withTitleAndDescription(
			string account, string username, string password, string prjName, string version
			,  string title,string description
		)
		{

			return Exe_twoFields(account,username,password,prjName, version,TITLE_PATH,title, DESCRIPTION_PATH,  description);
		}


		static public string Create_withTitleAndDescription_v1_0_(
			string account, string username, string password, string prjName,   string title,string description
		)
		{

			return Exe_twoFields(account,username,password,prjName, nilnul.dev.git.svr_.vs._url.Ver.v10,TITLE_PATH,title, DESCRIPTION_PATH,  description);
		}


	}
}
