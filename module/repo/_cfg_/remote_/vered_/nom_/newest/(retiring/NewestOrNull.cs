using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remotes_.ids_.named
{
	[Obsolete()]
	static public class _NewestOrNulX
	{
		public static string Exe(
			nilnul.fs.folder_.git_.Top folder,
			nilnul.txt_._vered_.Name name,
			nilnul.win.prog_.Git git = null
		)
		{
			return
				nilnul.txt.aggregate_.VerLatestOrNul.Singleton.aggregate(
					remotes_.ided._VwX.Exe(folder,name,git) 
				)
			;


		}
		public static string Exe(nilnul.fs.folder_.git_.Top folder, string name, nilnul.win.prog_.Git git = null)
		{
			return Exe(folder, new nilnul.txt_._vered_.Name(name), git);

		}


		public static string Exe(nilnul.fs.FolderI folder, string name, nilnul.win.prog_.Git git = null)
		{
			return Exe(new nilnul.fs.folder_.git_.Top(folder), name, git);

		}
		public static string Exe(string folder, string name, nilnul.win.prog_.Git git = null)
		{
			return Exe(new nilnul.fs.folder_.git_.Top(folder), name, git);

		}

	}
}
