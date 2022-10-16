using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.repo
{
	/// <summary>
	/// header loaded from cfg;
	/// cred loaded from vault
	/// </summary>
	///

	static public class _UrlX

		//ISerializable
	{
		

	
		static public string Url_withCred( string username, string repo)
		{
			return $"https://{username}@github.com/{username}/{repo}.git";
		}

	

		/// <summary>
		/// no Cred
		/// </summary>
		/// <param name="username"></param>
		/// <param name="repo"></param>
		/// <returns></returns>
		static public string Url( string username, string repo)
		{
			return $"https://github.com/{username}/{repo}.git";
		}


	}
}
