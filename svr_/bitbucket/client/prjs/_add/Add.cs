using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.prjs
{
	public class Add
	{

		private svr_.BitBucket _svr;

		public svr_.BitBucket svr
		{
			get { return _svr; }
			set { _svr = value; }
		}

		public Add(svr_.BitBucket svr)
		{
			_svr = svr;
		}


		public string exe(string prjName) {

			return ByBasicUser_useWebRequest(
				_svr.credential.username
				,
				_svr.credential.password,
				prjName	
			);
		}
		public string exe_errAsMsg(string prjName) {
			try
			{
			return ByBasicUser_useWebRequest(
				_svr.credential.username
				,
				_svr.credential.password,
				prjName	
			);

			}
			catch (Exception e)
			{
				return e.Message;

				//throw;
			}
		}


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
