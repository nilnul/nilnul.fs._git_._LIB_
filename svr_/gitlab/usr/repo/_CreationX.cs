using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System;

namespace nilnul.fs.git.svr_.gitlab.client.prj
{
	/// <summary>
	/// token in url;
	/// </summary>

	static public class _CreationX
	{




		/// <summary>
		/// "." will be replaced with "-" for the dir, but not the name.
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="_prjName__normalized">must be normalized as the server will not do it automatically
		/// for creation, the name is converted by the server
		/// </param>
		/// <returns></returns>
		/// <exception cref="">
		/// 422 Unprocessable Entity
		///		if the repo name is invalid, when it has, say, "_.".
		///	400 when for group project, the token belongs to a usr other than group, and the usrname is not provided;
		///
		/// </exception>
		static public string _ByWebReq_assumesNormed(string privateToken, string _prjName__normalized)
		{
			var url = fs.git.svr_.gitlab.usr._TeamworksX._Address_assumeNormal(privateToken);    //it seems sometimes UrlBase works, sometime UrlBase_v3 works

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					name = _prjName__normalized

				});

				streamWriter.Write(json);
				//streamWriter.Flush();

			}

			try
			{
				var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				using (
					var streamReader = new StreamReader(httpResponse.GetResponseStream())
				)
				{
					var result = streamReader.ReadToEnd();
					return result;
				}

			}
			catch (WebException e)
			{
				// maybe the name is already there.

				throw new ArgumentException("the name might already is there", e);
			}



		}

		static public string _ByWebReq_nameAssumeUnnormed(string privateToken, string _prjName_unnormed)
		{
			return _ByWebReq_assumesNormed(
				privateToken
				,
				gitlab.repo._NameX.Encode(_prjName_unnormed)
			);



		}
	}
}

