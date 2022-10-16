using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.api.repos.user.repo.exist
{
	/// <summary>
	/// basic
	/// </summary>
	public class Client
	{

		static public bool ByBasicUser_useWebRequest(string username, string password, string repo_slug)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(Repo.CreateUrl2_0_(username, repo_slug));

			//	httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = nilnul.web.http._request.Method_.GET;

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);

			//using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			//{
			//	string json = new JavaScriptSerializer().Serialize(new
			//	{
			//		name = repo_slug

			//	});

			//	streamWriter.Write(json);
			//	streamWriter.Flush();
			//	streamWriter.Close();

			//}

			//var response = (httpWebRequest.GetResponse());

			try
			{
				HttpWebResponse httpResponse=null;
				try
				{
					httpResponse = (HttpWebResponse)(httpWebRequest.GetResponse());

				}
				catch (ArgumentNullException e)
				{
#if DEBUG
					//this is a bug in dot46.
#else
					throw e;
#endif
				}
				catch (WebException we) {
					var exceptionResponse =( (HttpWebResponse)(we.Response)).StatusCode;
					if (((HttpWebResponse)(we.Response)).StatusCode == HttpStatusCode.NotFound)
					{
						return false;
					}
					
					if (exceptionResponse== HttpStatusCode.Forbidden)
					{


					}

				}
				catch (Exception)
				{


					throw;
				}

				//var status = httpResponse.StatusCode;
				//if (status == HttpStatusCode.Forbidden)
				//{
				//	throw new UnauthorizedAccessException();
				//}
				//if (status == HttpStatusCode.NotFound)
				//{
				//	return false;
				//}
				return true;
			}

			catch (Exception)
			{

				throw;
			}



			//using (
			//	var streamReader = new StreamReader(httpResponse.GetResponseStream())
			//)
			//{
			//	var result = streamReader.ReadToEnd();
			//	streamReader.Close();
			//	return result;
			//}



		}

	}
}
