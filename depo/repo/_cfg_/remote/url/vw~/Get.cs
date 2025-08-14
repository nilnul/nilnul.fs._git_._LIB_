using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cfg.remote.url
{
	[Obsolete()]
	public class Get
	{

		/*
		If referential integrity has been broken:
git config --get remote.origin.url


If referential integrity is intact:
git remote show origin



			 */
		static public string IfRefBroken(nilnul.fs.folder_.git_.Top folder, string remote,  nilnul.win.prog_.Git git=null)
		{
			 return (git??Git.StaticInstance).runCmd__retResult_throwErr(folder, $"config --get remote.{remote}.url");


		}

		/*
If referential integrity is intact:
git remote show origin
*/


		static public string IfRefIntegral(nilnul.fs.folder_.git_.Top folder, string remote,  nilnul.win.prog_.Git git=null)
		{
			 return (git??Git.StaticInstance).runCmd__retResult_throwErr(folder, $"remote show {remote}");


		}

		/*To get the answer:
git ls-remote --get-url [REMOTE]


This is better than reading the config; refer to the man page for git-ls-remote:


--get-url

Expand the URL of the given remote repository taking into account any "url.<base>.insteadOf" config setting (See git-config(1)) and exit without talking to the remote.
*/
		static public string LsRemote(nilnul.fs.folder_.git_.Top folder, string remote,  nilnul.win.prog_.Git git=null)
		{


			 return (git??Git.StaticInstance).runCmd__retResult_throwErr(folder, $"ls-remote --get-url {remote}");


		}

		/// <summary>
		/// With nilnul.win.prog_.Git 2.7 (release January 5th, 2015), you have a more coherent solution using git remote:
		/// git remote get-url origin
		/// (nice pendant of git remote set-url origin <newurl>)

		/// </summary>
		/// <param name="folder"></param>
		/// <param name="remote"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public string RemoteGetUrl(nilnul.fs.folder_.git_.Top folder, string remote,  nilnul.win.prog_.Git git=null)
		{


			 return (git??Git.StaticInstance).runCmd__retResult_throwErr(folder, $"remote get-url {remote}");


		}

		/*
$ git remote show -n origin

Some info:
1.$ git remote -v will print all remotes (not what you want). You want origin right?
2.$ git remote show origin much better, shows only origin but takes too long (tested on git version 1.8.1.msysgit.1).

I ended up with: $ git remote show -n origin, which seems to be fastest. With -n it will not fetch remote heads (AKA branches). You don't need that type of info, right?

http://www.kernel.org/pub//software/scm/git/docs/git-remote.html
*/
		static public string RemoteShow(nilnul.fs.folder_.git_.Top folder, string remote,  nilnul.win.prog_.Git git=null)
		{


			 return (git??Git.StaticInstance).runCmd__retResult_throwErr(folder, $"remote show -n {remote}");


		}


	}
}
