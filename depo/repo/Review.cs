using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo
{
	/// <summary>
	/// reflog for module in that it contains detached commits which would be gc-ed later.
	/// log for repo in that it contains the commits.
	/// </summary>
	/// vs:
	///		depo.reflog:
	///			record of the commit history of the repository, whereas the reflog is private.
	///	alias:
	///		review
	///			, view again
	class Review
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
