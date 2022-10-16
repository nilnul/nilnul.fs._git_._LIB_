using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote.url.vw_
{
	static public class _LsRemoteX
	{


		/*To get the answer:
git ls-remote --get-url [REMOTE]


This is better than reading the config; refer to the man page for git-ls-remote:


--get-url

Expand the URL of the given remote repository taking into account any "url.<base>.insteadOf" config setting (See git-config(1)) and exit without talking to the remote.
only first one
*/
		static public string Exe(nilnul.fs.folder_.git_.Top folder, _remote.Name remote, nilnul.win.prog_.Git git=null)
		{


			return // must be trimmed or / r / n is included
			   nilnul.txt.convert_.trim_.White.Singleton.op(nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(folder, $"ls-remote --get-url {remote}",git));


		}

		

	


	}
}
