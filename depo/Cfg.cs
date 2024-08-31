using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/*
	 git config --global --unset credential.helper


use --global or --local or --system as per your needs.

		 */
	 class Cfg
	{

		/*git config --add remote.all.url ssh://user@server/repos/g0.git
		git config --add remote.all.url ssh://user@server/repos/g1.git
			*/

		static void Add(string[] args)
		{
				
		}
		/// <summary>
		/// git remote set-url --add --push origin 
		/// </summary>
		/// <remarks>
		

		/// </remarks>

		/*
	[remote "origin"]
	url = git@gitlab.com:namespace/repo.git
	fetch = +refs/heads/*:refs/remotes/origin/*
	pushurl = git@gitlab.com:namespace/repo.git
	pushurl = git@bitbucket.org:namespace/repo.git

		 * */
		static void AddRemotePush() { }


	}
}
