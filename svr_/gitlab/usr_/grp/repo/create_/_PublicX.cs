using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using nilnul.fs.git.svr_.gitlab.repo;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp.repo.create_
{
	static public class _PublicX
	{
		public static string ByWebReq(int grpId, Name name, string privateToken)
		{
			return _ByWebReq_1repoNameNormalized(
				grpId
				,
				name.ToString()
				,
				privateToken
			);

		}

		static public string _ByWebReq_1unnormed(
			int grp
			,
			string _prjName__normalized
			,

			string privateToken
		)
		{
			return ByWebReq(
				grp
				,
				fs.git.svr_.gitlab.repo.Name.Normalize(_prjName__normalized)
				,
				privateToken
			);

		}

		/// <summary>
		/// "." will be replaced with "-" for the dir, but not the name.
		/// </summary>
		/// <param name="privateToken"></param>
		/// <param name="_prjName__normalized">must be normalized as the server will not do it automatically
		/// for creation, the name is converted by the server
		/// </param>
		/// <returns></returns>
		static public string _ByWebReq_1repoNameNormalized(
			int grp
			,
			string _prjName__normalized
			,
			string privateToken
		)
		{
			var url = gitlab.usr_.grp._TeamworksX.Url_0grpId_1token(grp, privateToken);

			//$"{Projects.UrlBase_v3}?private_token={privateToken}";    //it seems sometimes UrlBase works, sometime UrlBase_v3 works

			var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

			httpWebRequest.ContentType = "application/json";
			httpWebRequest.Method = "POST";

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					name = _prjName__normalized
					,
					visibility= "public"

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

