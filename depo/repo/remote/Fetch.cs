using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._git.git._module.module.config.remote
{
	class Fetch
	{
		/*
		 If you want nilnul.win.prog_.Git instead to pull down only the master branch each time, and not every other branch on the remote server, you can change the fetch line to
fetch = +refs/heads/master:refs/remotes/origin/master

		 */

		/*
		 [remote "origin"]
	url = https://github.com/schacon/simplegit-progit
	fetch = +refs/heads/master:refs/remotes/origin/master
	fetch = +refs/heads/experiment:refs/remotes/origin/experiment
	You can’t use partial globs in the pattern, so this would be invalid:
fetch = +refs/heads/qa*:refs/remotes/origin/qa*

		However, you can use namespaces (or directories) to accomplish something like that. If you have a QA team that pushes a series of branches, and you want to get the master branch and any of the QA team’s branches but nothing else, you can use a config section like this:
[remote "origin"]
	url = https://github.com/schacon/simplegit-progit
	fetch = +refs/heads/master:refs/remotes/origin/master
	fetch = +refs/heads/qa/*:refs/remotes/origin/qa/*


		 */



		static void Main(string[] args)
		{

		}

		/*
	 https://git-scm.com/book/en/v2/Git-Internals-The-Refspec says: 
	 (((((((((((((((((((((((((((((((((((((((((((((((((((((((
	 [remote "origin"]
url = https://github.com/schacon/simplegit-progit
fetch = +refs/heads/*:refs/remotes/origin/*

The format of the refspec is an optional +, followed by <src>:<dst>, where <src> is the pattern for references on the remote side and <dst> is where those references will be written locally. The + tells nilnul.win.prog_.Git to update the reference even if it isn’t a fast-forward.
))))))))))))))))))))))))))))))))))))))))))))))

	 */
		static void SetFetch(string[] args)
		{

		}

	}
}
