using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remoteUrls
{
	public class Add
	{

		public static void 	Eval(Folder folder, string remote, string url)
		{
				folder.runCmd_throwErr($"remote add {remote} {url}");


			}
			/*
			 git config --add remote.origin.url git@host.com:user/repo.git
			 */

			/*
			 [remote "origin"]

		fetch = +refs/heads/*:refs/remotes/origin/*

		url = C:/work/repo.git

		url = C:/backup/repo.git
			 */

			static public void ByCfg(Folder folder, string remote, params string[] urls)
		{
			




		}
	}
}
