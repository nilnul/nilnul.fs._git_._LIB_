using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	static public class _CleanX
	{
		/// <summary>
		/// Cleans the working tree by recursively removing files that are not under version control, starting from the current directory.
		/// Normally, only files unknown to git are removed, but if the -x option is specified, ignored files are also removed.This can, for example, be useful to remove all build products.
		/// If any optional<path>… arguments are given, only those paths are affected.
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		/// <param name="branch"></param>
		static public void CleanByForce(nilnul.win.prog_.Git git, string _module) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module,
				$"clean -f"
			);
		}

		/// <summary>
		/// d 
		/// Remove untracked directories in addition to untracked files.If an untracked directory is managed by a different git repository, it is not removed by default. Use -f option twice if you really want to remove such a directory. 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		static public void CleanIncludingUntrackedFolderByForce(nilnul.win.prog_.Git git, string _module) {
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module,
				$"clean -df" 

			);
		}

		static public void CleanByForce( string _module) {
			CleanByForce(nilnul.win.prog_.Git.StaticInstance,_module);
		}


	}
}
