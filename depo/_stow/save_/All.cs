using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash.save_
{
	static public class _AllX
	{
		
		static public void Exe(nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				_module
				,
				"stash save --all"
				,
				git
			);
		}


		/// <summary>
		/// For next time:
		/// git stash save --include-untracked
		/// or
		/// git stash save --all
		/// The last one stashes and cleans even ignored files.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		static public void Exe( nilnul.fs.FolderI _module, nilnul.win.prog_.Git git=null)
		{
			Exe(
				new nilnul.fs.folder_.git_.Top(_module),git
			);
		}

	
		static public void Exe( string _module,  nilnul.win.prog_.Git git = null)
		{
			Exe( nilnul.fs.Folder.FroAddress(_module),git);
		}


		


	}
}
