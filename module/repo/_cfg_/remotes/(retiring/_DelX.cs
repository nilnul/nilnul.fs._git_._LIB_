using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes
{
	[Obsolete()]
	static public class _DelX1
	{
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, IEnumerable< _cfg_._remote.Name> remotes, nilnul.win.prog_.Git git =null)
		{

			remotes.ForEach(
				remote=> { _cfg_.remote._DropX.ByRemote(folder, remote, git); }
			);

		}
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, IEnumerable< string> remotes, nilnul.win.prog_.Git git =null)
		{
			ByRemote(folder,remotes.Select(x=> new _remote.Name(x)),git);

		}


		public static void ByRemote( nilnul.fs.FolderI folder, IEnumerable< string> remotes, nilnul.win.prog_.Git git =null)
		{
			ByRemote( new nilnul.fs.folder_.git_.Top(folder) ,remotes.Select(x=>  new _remote.Name(x)), git);

		}
		public static void ByRemote(string folder, IEnumerable< string> remotes, nilnul.win.prog_.Git git =null)
		{
			ByRemote( new nilnul.fs.folder_.git_.Top(folder) ,remotes, git);

		}



		
	}
}
