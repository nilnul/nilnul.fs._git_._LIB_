using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.add_
{
	/// <summary>
	/// removed, updated, new but not tracked
	/// </summary>
	/// 
	[Obsolete()]
	static public class _AllX
	{
		static public void Exe( nilnul.fs.folder_.git_.Top _module , nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.Git.RunCmd_retVoid(
				_module, "add -A"
				,
				git
			);
		}

		static public void Exe( nilnul.fs.FolderI _module , nilnul.win.prog_.Git git=null)
		{
			Exe(new fs.folder_.git_.Top(_module),git);
		}

		static public void Exe( string _module , nilnul.win.prog_.Git git=null)
		{
			Exe(new fs.folder_.git_.Top(_module),git);
		}

	}
}
