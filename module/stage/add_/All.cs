using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.add_
{
	/// git add -A
	/// -or-
	/// git add --all
	/// note: git add -a is error;
	/// <summary>
	/// including：
	///		removed,
	///		updated, 
	///		new but not tracked
	///	not including:
	///		ignored
	/// </summary>
	/// <remarks>
	/// vs:
	///		git commit --all,
	///			which "Tell the command to automatically stage files that have been modified and deleted, but new files you have not told Git about are not affected."
	///	vs:
	///		git add . stages new files and modifications, without deletions (on the current directory and its subdirectories).
	///	vs:
	///		git add -u stages modifications and deletions, without new files
	/// </remarks>
	static public class _AllX
	{
		/// <summary>
		/// exitCode 128 if innerModule is not excluded and not commited.
		/// </summary>
		/// <param name="_module"></param>
		/// <param name="git"></param>
		static public void Exe( nilnul.fs.folder_.git_.Top _module , nilnul.win.prog_.Git git=null)
		{
			//fs.git.module.repo.unlock_.wait._TimeoutX._Timeout_addressAssumeModule(_module.ToString());
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.Void(
				_module, "add -A"
				,
				git
			);
		}

		static public void Exe( nilnul.fs.FolderI _module , nilnul.win.prog_.Git git=null)
		{
			Exe(new fs.folder_.git_.Top(_module),git);
		}

		static public void Exe_ofAddress( string _module , nilnul.win.prog_.Git git=null)
		{
			Exe( fs.folder_.git_.Top.FroAddress(_module),git);
		}

	}
}
