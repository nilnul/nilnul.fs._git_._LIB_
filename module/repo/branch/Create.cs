using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch
{
	static public class _CreateX
	{
		public static void _Exe( fs.FolderI folder, string _branch, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(folder, $"branch {_branch}",git);   //will throw 
		}
		public static void _Exe( fs.Folder folder, string _branch, nilnul.win.prog_.Git git=null)
		{
			_Exe((FolderI)folder,  _branch,git);
		}

		
	}
}
