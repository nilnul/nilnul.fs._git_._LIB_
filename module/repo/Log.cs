using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	/// <summary>
	/// reflog for module in that it contains detached commits which would be gc-ed later.
	/// log for repo in that it contains the commits.
	/// </summary>
	public class Log
	{
		/*
		 $ git log origin/master
$ git log remotes/origin/master
$ git log refs/remotes/origin/master

They’re all equivalent, because nilnul.win.prog_.Git expands each of them to refs/remotes/origin/master.

		 */

		/*
		 git log --all --decorate --graph --oneline
		 */

	}
}
