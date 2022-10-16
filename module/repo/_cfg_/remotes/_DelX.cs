using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using nilnul.fs.git.module.repo._cfg_._remote;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo._cfg_.remotes
{
	//extern alias fs;
	static public class _DelX
	{
		public static void ByRemote(nilnul.fs.git.ModuleI folder, IEnumerable< _cfg_._remote.Name> remotes, nilnul.win.prog_.Git git =null)
		{

			remotes.ForEach(
				remote=> { _cfg_.remote._DropX1.ByRemote(folder, remote, git); }
			);

		}
		public static void ByRemote(Top folder, IEnumerable<_remote.Name> enumerable, win.prog_.Git git)
		{
			ByRemote(new nilnul.fs.git.Module(folder) as ModuleI,enumerable,git);
		}
		public static void ByRemote(nilnul.fs.folder_.git_.Top folder, IEnumerable< string> remotes, nilnul.win.prog_.Git git =null)
		{
			ByRemote(folder,remotes.Select(x=> new _remote.Name(x)),git);

		}


		public static void ByRemote( nilnul.fs.FolderI folder, IEnumerable< string> remotes, nilnul.win.prog_.Git git =null)
		{
			ByRemote( new nilnul.fs.folder_.git_.Top(folder) ,remotes.Select(x=>  new _remote.Name(x)), git);

		}
		public static void _ByRemote_topAddress(string _top_address, IEnumerable< string> remotes, nilnul.win.prog_.Git git =null)
		{
			ByRemote(  nilnul.fs.folder_.git_.Top.FroAddress(_top_address) ,remotes, git);

		}



		
	}
}
