using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._branch.create_
{
	public class NoHistory
	{
		/*
		 git checkout --orphan branchname
git rm -rf .		//this will clear the space or maybe the stage?

		 */

		static public void _Exe(FolderI _module, string _branch, Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(_module, $"checkout --orphan {_branch}",git);  
		}

		static public void _Exe( nilnul.fs.Folder _module, string _branch, nilnul.win.prog_.Git git)
		{
			_Exe((FolderI)_module,_branch,git);
		}

	




		static public void _Exe(string  _module, string _branch, Git git=null)
		{
			_Exe( nilnul.fs.Folder.FroAddress(_module),_branch,git );
		}
	}
}
