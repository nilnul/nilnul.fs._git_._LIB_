using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_
{
	//extern alias fs;
	static public class _DelX
	{
		public static void Exe(
			nilnul.fs.folder_.git_.Top folder, 
			nilnul.txt_._vered_.Name name, nilnul.win.prog_.Git git =null
		)
		{
			remotes._DelX.ByRemote(
				folder
				,
				remote_.vered_.name._VwX.Exe(folder,name, git)
				,
				git
			);
			

		}
		public static void Exe(nilnul.fs.folder_.git_.Top folder, string name, nilnul.win.prog_.Git git =null)
		{
			Exe(folder, new nilnul.txt_._vered_.Name(name),git);

		}


		public static void Exe( nilnul.fs.FolderI folder, string name, nilnul.win.prog_.Git git =null)
		{
			Exe( new nilnul.fs.folder_.git_.Top(folder) ,name, git);

		}
		public static void Exe(string folder, string name, nilnul.win.prog_.Git git =null)
		{
			Exe(  nilnul.fs.folder_.git_.Top.FroAddress(folder) ,name, git);

		}



		
	}
}
