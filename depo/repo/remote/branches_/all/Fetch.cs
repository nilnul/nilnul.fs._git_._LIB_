using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.branches_.all
{
	static public class _FetchX
	{
		/*
		 •Update the remote-tracking branches:


$ git fetch origin


The above command copies all branches from the remote refs/heads/ namespace and stores them to the local refs/remotes/origin/ namespace, unless the branch.<name>.fetch option is used to specify a non-default refspec.

			 */
		/// <summary>
		/// 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <param name="remote"></param>
		static public void _Fetch(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string remote) {

			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(_module, $"fetch {remote}");
		}
	}
}
