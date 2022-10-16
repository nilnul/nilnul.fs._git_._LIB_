using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes_.ided
{
	[Obsolete()]
	static public class _VwX
	{
		public static IEnumerable<string> Exe(
			nilnul.fs.folder_.git_.Top folder, 
			nilnul.txt_._nameVer_.Name name, 
			nilnul.win.prog_.Git git =null
		)
		{
			return 
				remotes.Vw1.Seq(folder,git).Where(
					x=> nilnul.txt_._NameVerX.IsNamedAs(name,x)
				)
				;
			

		}
		public static IEnumerable<string> Exe(nilnul.fs.folder_.git_.Top folder, string name, nilnul.win.prog_.Git git =null)
		{
			return Exe(folder, new nilnul.txt_._nameVer_.Name(name),git);
		}

		public static IEnumerable<string> Exe( nilnul.fs.FolderI folder, string name, nilnul.win.prog_.Git git =null)
		{
			return Exe( new nilnul.fs.folder_.git_.Top(folder) ,name, git);

		}
		public static IEnumerable<string> Exe(string folder, string name, nilnul.win.prog_.Git git =null)
		{
			return Exe( new nilnul.fs.folder_.git_.Top(folder) ,name, git);

		}



		
	}
}
