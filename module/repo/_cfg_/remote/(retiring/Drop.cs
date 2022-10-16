using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote
{
	//extern alias fs;
	[Obsolete()]
	static public class _DropX
	{
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, _cfg_._remote.Name remote, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.Git.RunCmd_retVoid(folder,  $"remote remove {remote}",git);

		}
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, string remote, nilnul.win.prog_.Git git =null)
		{
			ByRemote(folder, new _remote.Name(remote),git);

		}



		public static void ByRemote( nilnul.fs.FolderI folder, string remote, nilnul.win.prog_.Git git =null)
		{
			ByRemote( new nilnul.fs.folder_.git_.Top(folder) ,remote, git);

		}

public static void ByRemote( string folder, string remote, nilnul.win.prog_.Git git =null)
		{
			ByRemote( new nilnul.fs.folder_.git_.Top(folder) ,remote, git);

		}		
	}
}
