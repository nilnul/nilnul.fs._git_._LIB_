using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes
{
	//extern alias fs;
	[Obsolete()]
	static public class _DelX
	{
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, _cfg_._remote.Name remote, nilnul.win.prog_.Git git=null)
		{
			Git.RunCmd_retVoid(folder,  $"remote remove {remote}",git);

		}
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, string remote, nilnul.win.prog_.Git git=null)
		{
			ByRemote(folder, new _remote.Name(remote),git);

		}


		public static void ByRemote( nilnul.fs.Folder folder, string remote, nilnul.win.prog_.Git git=null)
		{
			ByRemote( new nilnul.fs.folder_.git_.Top(folder) ,remote, git);

		}

		[Obsolete()]
		public static void ByRemote(nilnul.win.prog_.Git git, nilnul.fs.Folder folder, string remote)
		{
			git.runCmd_throwErr(folder, $"remote remove {remote}");

		}

		[Obsolete()]
		public static void ByRemote( nilnul.fs.Folder folder, string remote)
		{
			ByRemote(nilnul.win.prog_.Git.StaticInstance,folder,remote);

		}
	}
}
