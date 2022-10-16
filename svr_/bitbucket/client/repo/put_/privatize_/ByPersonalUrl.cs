using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace nilnul.fs.git.svr_.bitBucket.client.repo.put_.privatize_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _ByPersonalUrlX
	{



		static public string GetUrl(string username, string repoName) {

			return $"{BitBucket.url2_0}/users/~{username}/repos/{repoName}";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="username"></param>
		/// <param name="repoName"></param>
		/// <returns></returns>
		static public string GetUrl2_0(string username, string repoName)
		{
			/*
			Resource URL

/2.0/repositories/{username}/{repo_slug}
			 
			 */

			return $"{BitBucket.url2_0}/repositories/{username}/{repoName}";
		}

		static public string GetUrl1_0(string username, string repoName)
		{
			/*
			Resource URL

/2.0/repositories/{username}/{repo_slug}
			 
			 */

			return $"{BitBucket.url1_0}/repositories/{username}/{repoName}";
		}

		static public string GetUrl1_0__noUser(string username, string repoName)
		{
			/*
			Resource URL

/2.0/repositories/{username}/{repo_slug}
			 
			 */

			return $"{BitBucket.url1_0}/repositories/{repoName}";
		}

		static public string GetUrl2_0__noUser(string username, string repoName)
		{
			/*
			Resource URL

/2.0/repositories/{username}/{repo_slug}
			 
			 */

			return $"{BitBucket.url2_0}/repositories/{repoName}";
		}


		public static string ByBasicUser_useWebRequest(NetworkCredential credential, string repo)
		{

			return ByBasicUser_useWebRequest(
				credential.UserName
				, credential.Password
				,
				repo
			);

		}
		static public string ByBasicUser_useWebRequest(string username, string password, string repoName)
		{
			var httpWebRequest = (HttpWebRequest)WebRequest.Create(GetUrl2_0__noUser(username, repoName));

			httpWebRequest.ContentType = "application/json";

			httpWebRequest.Method = nilnul.web.http._request.Method_.PUT;

			httpWebRequest.Headers.Add("Authorization",

				"Basic " + Convert.ToBase64String(
							System.Text.ASCIIEncoding.ASCII.GetBytes(
								string.Format("{0}:{1}", username, password)
							)
				)
			);

			using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
			{
				string json = new JavaScriptSerializer().Serialize(new
				{
					is_private = false

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
	/*
	Personal Repositories

Bitbucket allows users to manage their own repositories, called personal repositories. These are repositories associated with the user and to which they always have REPO_ADMIN permission. 

Accessing personal repositories via REST is achieved through the normal project-centric REST URLs using the user's slug prefixed by tilde as the project key. E.g. to list personal repositories for a user with slug "johnsmith" you would make a GET to: 
http://example.com/rest/api/1.0/projects/~johnsmith/repos

In addition to this, Bitbucket allows access to these repositories through an alternate set of user-centric REST URLs beginning with: 
http://example.com/rest/api/1.0/users/~{userSlug}/repos
E.g. to list the forks of the repository with slug "nodejs" in the personal project of user with slug "johnsmith" using the regular REST URL you would make a GET to: http://example.com/rest/api/1.0/projects/~johnsmith/repos/nodejs/forks
Using the alternate URL, you would make a GET to: http://example.com/rest/api/1.0/users/johnsmith/repos/nodejs/forks
	 */
}
