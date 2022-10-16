using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.remote.net
{
	/*
	If someone else administers the server, they should tell you what directory to put the repository in, and what git:// URL it will appear at. You can then skip to the section "Pushing changes to a public repository", below.

Otherwise, all you need to do is start git-daemon(1); it will listen on port 9418. By default, it will allow access to any directory that looks like a nilnul.win.prog_.Git directory and contains the magic file git-daemon-export-ok. Passing some directory paths as git daemon arguments will further restrict the exports to those paths.


		 */
	class Daemon
	{
	}
}
