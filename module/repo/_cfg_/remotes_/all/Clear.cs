using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.all
{
	static public class _ClearX
	{

		public static void Clear( nilnul.fs.Folder folder, nilnul.win.prog_.Git git=null)
		{
			remotes._DelX.ByRemote(
				folder,
				remotes._VwX.Seq(folder,git)
				,git
			);

		}


	}
}
