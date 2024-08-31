using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches.add_
{
	public class NoHistory
	{
		/*
		 git checkout --orphan branchname
git rm -rf .		//this will clear the space or maybe the stage?

		 */

		static public void _Exe(git.Folder _module, string _branch)
		{
			_module.runCmd_throwErr($"checkout --orphan {_branch}");  
		}
		static public void _Exe(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string _branch)
		{
			git.runCmd_throwErr(_module, $"checkout --orphan {_branch}");
		}

		static public void _Exe_clearStage(nilnul.win.prog_.Git git, nilnul.fs.Folder _module, string _branch)
		{
			git.runCmd_throwErr(_module, $"checkout --orphan {_branch}");
			nilnul.fs.git.module.stage._ClearX.Clear(git,_module);

		}

		static public void _Exe_clearStage( nilnul.fs.Folder _module, string _branch)
		{
			_Exe_clearStage(nilnul.win.prog_.Git.StaticInstance, _module, _branch);

		}



		static public void _Exe( nilnul.fs.Folder _module, string _branch)
		{
			_Exe(nilnul.win.prog_.Git.StaticInstance, _module,_branch);
		}

		static public void _Exe(string  _module, string _branch)
		{
			nilnul.fs.git.Module.RunCmd_throwErr(_module, $"checkout --orphan {_branch}");  
		}
	}
}
