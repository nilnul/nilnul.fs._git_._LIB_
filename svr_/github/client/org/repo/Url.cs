using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.github.client.org.repo
{
	/// <summary>
	/// header loaded from cfg;
	/// cred loaded from vault
	/// </summary>
	///

	static public class _UrlX

		//ISerializable
	{
		

	
	

		static public string Url_withUsername( string org, string repo, string username1)
		{
			return $"https://{username1}@github.com/{org}/{repo}.git";
		}

		/// <summary>
		/// eg:
		///		git@github.com:nilnul/_nilnul_._LINQ_.git
		/// </summary>
		/// <param name="org"></param>
		/// <param name="repo"></param>
		/// <param name="username1">git is used as the username. When you clone using an ssh link from a git server, the username it uses is git, not the username of the key you are trying to use.</param>
		/// <returns></returns>
		static public string Ssh_withUsername( string org, string repo)
		{
			return $"git@github.com:{org}/{repo}.git";
		}

		/// <summary>
		/// no Cred
		/// </summary>
		/// <param name="org"></param>
		/// <param name="repo"></param>
		/// <returns></returns>
		static public string Url( string org, string repo)
		{
			return $"https://github.com/{org}/{repo}.git";
		}


	}
}
