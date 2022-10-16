using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.client_.token.prjs
{
	public class Add
	{

		private svr_.bitBucket.client_.Token _client;

		public svr_.bitBucket.client_.Token client
		{
			get { return _client; }
			set { _client = value; }
		}

		public Add(svr_.bitBucket.client_.Token svr)
		{
			_client = svr;
		}


		public string exe(string prjName) {

			return ByWebRequest(
				
				_client.token
				,
				prjName	
			);
		}
		public string exe_errAsMsg(string prjName) {
			try
			{
			return ByWebRequest(
				
				_client.token

				,
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
		static public string ByWebRequest( string password, string prjName)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(Projects.Url_1_0_);

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = "POST";

			httpWebRequest.Headers.Add("Authorization", 

				"Bearer " +Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}",  password)
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
