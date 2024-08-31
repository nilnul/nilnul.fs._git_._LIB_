using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes.del_
{
	//extern alias fs;
	static public class _VersionedX
	{
		public static void Exe(
			nilnul.fs.folder_.git_.Top folder, 
			nilnul.txt_._nameVer_.Name name, nilnul.win.prog_.Git git =null
		)
		{
			remotes._DelX1.ByRemote(
				folder
				,
				remotes_.ided._VwX.Exe(folder,name, git)
				,
				git
			);
			

		}
		public static void Exe(nilnul.fs.folder_.git_.Top folder, string name, nilnul.win.prog_.Git git =null)
		{
			Exe(folder, new nilnul.txt_._nameVer_.Name(name),git);

		}


		public static void Exe( nilnul.fs.FolderI folder, string name, nilnul.win.prog_.Git git =null)
		{
			Exe( new nilnul.fs.folder_.git_.Top(folder) ,name, git);

		}
		public static void Exe(string folder, string name, nilnul.win.prog_.Git git =null)
		{
			Exe( new nilnul.fs.folder_.git_.Top(folder) ,name, git);

		}



		
	}
}
