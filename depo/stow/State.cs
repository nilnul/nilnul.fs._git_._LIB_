using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// stackoverflow.com/questions/70147614/git-index-messed-up
	/// 
	/// The git status command works in part by running two git diffs:
	///		git diff --staged --name-status
	///			,change to be committed,which compares HEAD to the files in Git's index.
	///			,If we move HEAD (and the current branch name) around without changing the index content, we'll have the two out of sync, and many files might be changed, or even deleted. For instance, if we move main backwards from J to H, but leave the index alone, all the files that are different between H and J will show up.
	///		git diff --name-status
	///			,change not staged for commit
	///			,The second comparison git status does compares the files in Git's index to those in your working tree. This is a lot like running git diff --name-status with no options.
	///			
	/// <summary>
	/// read the state of the module, including work, index, and repo/commited
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// What git status tells you is both the answer to "what, if anything, is staged for commit" and "what, if anything, is different between the work-tree and the index".
	/// 
	public class State
	{

		static public string  _GetStatus(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"status"
			);
		}


		static public string  _GetStatus(nilnul.win.prog_.Git git, nilnul.fs.Folder _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module
				,
				"status"
			);
		}

		static public string  _GetStatus( string _module)
		{
			return _GetStatus(nilnul.win.prog_.Git.StaticInstance, _module);;
		}

		static public string  _GetStatus( nilnul.fs.Folder _module)
		{
			return _GetStatus(nilnul.win.prog_.Git.StaticInstance, _module);;
		}

	}
}
