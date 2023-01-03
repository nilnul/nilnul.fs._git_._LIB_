using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	


	public class _StashX
	{
		static public string _List(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"stash list"
			);
		}
		static public string _List( string _module)
		{
			return _List(nilnul.win.prog_.Git.StaticInstance, _module); ;
		}

		static public string _Show(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"stash show"
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
		static public void _StashAll(nilnul.win.prog_.Git git, string _module)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module
				,
				"stash save --all"
			);
		}

		/// <summary>
		/// As of git 1.7.7, git stash accepts the --include-untracked option(or short-hand -u). To include untracked files in your stash, use either of the following commands:
		/// git stash --include-untracked
		/// git stash -u
		/// Warning, doing this will permanently delete your files if you have any directory/* entries in your gitignore file.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// 
		[Obsolete("Warning, doing this will permanently delete your files if you have any directory/* entries in your gitignore file", true)]
		static public void _StashEvenUntracked(nilnul.win.prog_.Git git, string _module)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module
				,
				"stash save -u --all"
			);
		}


		/// <summary>
		/// same as: git stash save
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		static public void _StashOnlyTracked(nilnul.win.prog_.Git git, string _module)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module
				,
				"stash"
			);
		}






		static public void _StashOnlyTracked( string _module)
		{
			 _StashOnlyTracked(nilnul.win.prog_.Git.StaticInstance, _module);
		}

		static public void _StashAll( string _module)
		{
			 _StashAll(nilnul.win.prog_.Git.StaticInstance, _module);
		}


		/// <summary>
		/// restored (potentially on top of a different commit) with git stash apply. 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public string _Apply(nilnul.win.prog_.Git git, string _module)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module
				,
				"stash apply"
			);
		}

		/// <summary>
		/// pop[--index][-q | --quiet][< stash >]
		/// Remove a single stashed state from the stash list and apply it on top of the current working tree state, i.e., do the inverse operation of git stash save.The working directory must match the index.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <returns></returns>
		static public void _Pop(nilnul.win.prog_.Git git, string _module)
		{
			 nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module
				,
				"stash pop" //When no <stash> is given, stash@{0} is assumed, otherwise <stash> must be a reference of the form stash@{<revision>}.
			);
		}



		static public void _Pop( string _module)
		{
			_Pop(nilnul.win.prog_.Git.StaticInstance,_module);
		}

	}
}
