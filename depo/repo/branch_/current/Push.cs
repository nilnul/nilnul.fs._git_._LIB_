using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch_.current
{
	static public class _PushX
	{

		static public void Exe( nilnul.fs.folder_.git_.Top folder, nilnul.fs.git.module.repo._cfg_._remote.Name remote, nilnul.win.prog_.Git git=null )
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(folder, $"push {remote}",git);
		}
		static public void Exe( nilnul.fs.Folder folder, string remote, nilnul.win.prog_.Git git=null )
		{
			Exe(
				new nilnul.fs.folder_.git_.Top(folder)
				,new nilnul.fs.git.module.repo._cfg_._remote.Name( remote)
				,git
			);
		}

	




	}
}
