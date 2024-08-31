using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using nilnul.fs.git.svr_.gitlab.repo;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp.colab._drop_.by_
{
	/// <summary>
	/// https://docs.gitlab.com/ee/api/projects.html#delete-project
	/// </summary>
	/// test passed
	static public class _WebReqX
	{

	



		/// <summary>
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="prjId">
		///If using namespaced API requests, make sure that the NAMESPACE/PROJECT_PATH is URL-encoded.
		///For example, / is represented by %2F:
		///GET /api/v4/projects/diaspora%2Fdiaspora
		///A project’s path isn’t necessarily the same as its name. A project’s path is found in the project’s URL or in the project’s settings, under General > Advanced > Change path.
		/// 
		/// </param>
		/// <returns></returns>
		/// <exception cref="" >
		/// forbidden if the usr is locked; a usr is locked if multiple signed-in failed (or sometimes a verification of code from email is required), and we can unlock by signing in, which would require a verification code via email;
		/// </exception>
		static public string _Response_0prj_1token(

			string prjId
			,

			string privateToken
		)
		{
			var url =
				//gitlab.usr_.grp._ColabX._Url_0prjId_1grpId_2token(prjId,grp, privateToken)

							 $"{usr._TeamworksX.SPEAR}/{prjId}?private_token={privateToken}";


			;

			//$"{Projects.UrlBase_v3}?private_token={privateToken}";    //it seems sometimes UrlBase works, sometime UrlBase_v3 works

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "DELETE";

			//var id = gitlab.usr_.grp._IdX.

			//using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			//{
			//	string json = new JavaScriptSerializer().Serialize(new
			//	{
			//		id = _prjName__normalized

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

