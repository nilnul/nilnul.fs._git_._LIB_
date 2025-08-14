using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.cfg
{
	static public class _VwX
	{
		/*
			Gives some information about the remote<name>.
With -n option, the remote heads are not queried first with git ls-remote<name>; cached information is used instead.
	 
			 */

			 /// <summary>
			 /// git remote[-v | --verbose] show[-n]  { name }…​
			 /// </summary>
			 /// <param name="git"></param>
			 /// <param name="folder"></param>
			 /// <param name="remote"> case sensitive</param>
			 /// <returns></returns>

		static public string  Vw(nilnul.win.prog_.Git git, nilnul.fs.Folder folder,  string remote)
		{
			return git.runCmd__retResult_throwErr(folder, $"remote -v show -n {remote}");
		}


		static public string  Vw( nilnul.fs.Folder folder,  string remote)
		{
			return Vw(nilnul.win.prog_.Git.StaticInstance, folder, remote);
		}

		/*
		 If referential integrity has been broken:
git config --get remote.origin.url


If referential integrity is intact:
git remote show origin


		 */



	}
}
