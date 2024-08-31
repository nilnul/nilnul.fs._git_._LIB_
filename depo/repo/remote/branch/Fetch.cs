using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.branch
{
	/// <summary>
	/// FETCH_HEAD will record the hash of the fetched head.
	/// </summary>
	static public class _FetchX
	{

		/*
		 To pull the master branch on the remote down to origin/mymaster locally, you can run
$ git fetch origin master:refs/remotes/origin/mymaster

		 */
		static public void _Fetch(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote, string branch) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"fetch {remote} {branch}");

		}

		static public void _Fetch( nilnul.fs.Folder _module, string remote, string branch) {
			_Fetch(nilnul.win.prog_.Git.StaticInstance, _module,remote,branch);

		}

	}
}
