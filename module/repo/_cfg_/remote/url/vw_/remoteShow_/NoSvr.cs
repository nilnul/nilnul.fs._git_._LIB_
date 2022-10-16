using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url.vw_.remoteShow_
{
	static public class _NoSvrX
	{

	

		/*
$ git remote show -n origin

Some info:
1.$ git remote -v will print all remotes (not what you want). You want origin right?
2.$ git remote show origin much better, shows only origin but takes too long (tested on git version 1.8.1.msysgit.1).

I ended up with: $ git remote show -n origin, which seems to be fastest. With -n it will not fetch remote heads (AKA branches). You don't need that type of info, right?

http://www.kernel.org/pub//software/scm/git/docs/git-remote.html
*/
		static public string RemoteShow(nilnul.fs.folder_.git_.Top folder, _remote.Name remote, nilnul.win.prog_.Git git=null)
		{


			return // must be trimmed or / r / n is included
				nilnul.txt.convert_.trim_.White.Singleton.op(
					nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"remote show -n {remote}",git));


		}


	}
}
