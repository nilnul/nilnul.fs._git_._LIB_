using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remotes
{
	public class Add
	{
		/*
		 You may encounter these errors when trying to add a remote.

Remote name already exists

This error means you've tried to add a remote with a name that already exists in your local repository:

$ git remote add origin https://github.com/octocat/Spoon-Knife

fatal: remote origin already exists.


		 */




			/// <summary>
			/// 
			/// </summary>
			/// <param name="folder"></param>
			/// <param name="remote"></param>
			/// <exception cref="">
			///  url is required
			/// </exception>
		[Obsolete("url is required",true)]
		static public void WithoutUrl(Folder folder, string remote)
		{
			folder.runCmd_throwErr($"remote add {remote}");

		}

		public static void ByRemote(Folder folder, string remote, string url)
		{
			folder.runCmd_throwErr($"remote add {remote} {url}");

		}


		/*
		 			 git config --add remote.origin.url git@host.com:user/repo.git

			seems exception.

			 */

			[Obsolete("exception",true)]
		static public void WithoutUrl_byCfg(Folder folder, string remote)
		{
			folder.runCmd_throwErr($"config --add remote {remote}");

		}



	}
}
