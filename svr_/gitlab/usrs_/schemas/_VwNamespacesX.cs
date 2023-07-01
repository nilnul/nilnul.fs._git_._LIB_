using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using nilnul.fs.git.svr_.gitlab.repo;

namespace nilnul.fs.git.svr_.gitlab.usrs_.schemas
{
	/// <summary>
	/// namespace_id through:
	/// curl -k --header "PRIVATE-TOKEN: <your secret token>" "https://gitlab.example.com/api/v3/namespaces"
	/// </summary>
	static public class _VwNamespacesX
	{

		/// <summary>
		/// </summary>
		/// <param name="privateToken"></param>
		/// <returns></returns>
		static public string ToResponse(

			string privateToken
		)
		{
			var url = gitlab.usrs_._NamespacesX.ToUrl( privateToken);

			//$"{Projects.UrlBase_v3}?private_token={privateToken}";    //it seems sometimes UrlBase works, sometime UrlBase_v3 works

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			//httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "GET";

			//using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			//{
			//	string json = new JavaScriptSerializer().Serialize(new
			//	{
			//		name = _prjName__normalized
			//		,
			//		visibility= "public"

			//	});

			//	streamWriter.Write(json);
			//	//streamWriter.Flush();

			//}

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

