using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remotes.cfg
{
	static public class _DelX
	{
		

		public static void ByRemote(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote)
		{
			git.runCmd_throwErr(folder, $"remote remove {remote}");

		}

		public static void ByRemote( nilnul.fs.Folder folder, string remote)
		{
			ByRemote(nilnul.win.prog_.Git.StaticInstance,folder,remote);

		}

	


	}
}
