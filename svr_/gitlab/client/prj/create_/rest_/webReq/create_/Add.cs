using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http;
using System.Net;
using System.IO;

namespace nilnul.fs.git.svr_.gitlab.prjs
{
	public class Add
	{

		private svr_.Gitlab _svr;

		public svr_.Gitlab svr
		{
			get { return _svr; }
			set { _svr = value; }
		}

		public Add(svr_.Gitlab gitLab)
		{
			_svr = gitLab;
		}


		public string exe(string prj) {

			return ByPrivateToken_useWebRequest(

				_svr.credential.txt
				,
				prj
					
			);
		}

		public string exe_errAsMsg(string prj) {
			try
			{
			return ByPrivateToken_useWebRequest(
				_svr.credential.txt
				,
				prj
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
		static public string ByPrivateToken_useWebRequest(string privateToken, string prjName)
		{
			var url = $"{Projects.UrlBase}?private_token={privateToken}";

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					name = prjName
					
				});

				streamWriter.Write(json);
				//streamWriter.Flush();

			}

			var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using (
				var streamReader = new StreamReader(httpResponse.GetResponseStream())
			)
			{
				var result = streamReader.ReadToEnd();
				return result;
			}

		

		}
	}
}
