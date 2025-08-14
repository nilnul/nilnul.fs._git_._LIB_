using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_._remote
{
	//extern alias web;
	//extern alias fs;
	[Obsolete()]
	static public class _CreateX
	{
		/*
		 You may encounter these errors when trying to add a remote.
Remote name already exists
This error means you've tried to add a remote with a name that already exists in your local repository:
$ git remote add origin https://github.com/octocat/Spoon-Knife
fatal: remote origin already exists.
		 */

		///// <exception cref="">
		/////  url is required
		///// </exception>
		//[Obsolete("url is required",true)]
		//static  void WithoutUrl(Folder folder, string remote)
		//{
		//	folder.runCmd_throwErr($"remote add {remote}");

		//}

		public static void RetVoid(nilnul.fs.Folder folder, string remoteName, string url,Git git=null)
		{
			RetVoid( new nilnul.fs.folder_.git_.Top(folder) ,remoteName,url,git);
		}

		public static void RetVoid(nilnul.fs.folder_.git_.Top folder, string remoteName, string url, nilnul.win.prog_.Git git=null)
		{
			RetVoid(
				folder,
				new Name(remoteName)
				,
				nilnul.web.url._ParseX2.Parse(url)
			);
			
		}

		public static void RetVoid(nilnul.fs.folder_.git_.Top folder, Name remoteName,nilnul.web.Url2 url, nilnul.win.prog_.Git git=null)
		{
			Git.RunCmd_retVoid(
				folder
				,
				$"remote add {remoteName} {url}"
				,git
			);
		}

		///*
		// 			 git config --add remote.origin.url git@host.com:user/repo.git
		//	seems exception.
		//	 */
		//[Obsolete("exception",true)]
		//static  void WithoutUrl_byCfg(Folder folder, string remote)
		//{
		//	folder.runCmd_throwErr($"config --add remote {remote}");
		//}
	}
}