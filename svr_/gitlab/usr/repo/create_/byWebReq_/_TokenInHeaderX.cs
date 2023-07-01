using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System;

namespace nilnul.fs.git.svr_.gitlab.usr.repo.create_.byWebReq_
{

	/// <summary>
	/// this works for only current usr;
	/// </summary>
	static public class _TokenInHeaderX
	{

		/// <summary>
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="_prjName__normalized">must be normalized as the server will not do it automatically
		/// for creation, the name is converted by the server
		/// </param>
		/// <returns></returns>
		/// <exception cref="">
		/// 422 Unprocessable Entity
		///		if the repo name is invalid, when it has, say, "_.".
		///
		/// </exception>
		static public string _AsResponse_1normed(string privateToken, string _prjName__normalized)
		{
			var url = fs.git.svr_.gitlab._PrjsX.SPEAR;    //it seems sometimes UrlBase works, sometime UrlBase_v3 works

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			httpWebRequest.ContentType = "application/json";
			//httpWebRequest.Headers.Add("Content-Type:application/json");

			httpWebRequest.Accept = "application/json";
			//httpWebRequest.Headers.Add("Accept:application/json");

			//httpWebRequest.autho
			//httpWebRequest.Headers[HttpRequestHeader.Authorization] = $"Bearer {privateToken}";
			httpWebRequest.Headers[usr.PrivateToken.Header_FieldName] = $"{privateToken}";


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

		static public string _AsResponse_1unnormed(string privateToken, string _prjName_unnormed)
		{
			return _AsResponse_1normed(
				privateToken
				,
				gitlab.repo._NameX.Encode(_prjName_unnormed)
			);



		}
	}
}

