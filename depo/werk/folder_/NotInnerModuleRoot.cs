using nilnul.dev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.folder_
{
	/// <summary>
	/// this is a work folder.
	/// there is no .git 'cuz this is nonRoot.
	/// 
	/// there can only be NonrootWork, or Rootwork inside this.
	/// </summary>
	/// <param name="_location__nonrootWork"></param>
	/// <param name="item"></param>

	public class NotInnerModuleRoot
	{

		/// <summary>
		/// this will init a submodule; 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location__nonrootWork"></param>
		static public void _Init(nilnul.win.prog_.Git git, string _location__nonrootWork)
		{
			nilnul.fs.folder.git_.Init.Void_ofAddress(_location__nonrootWork);
		}



	}
}
