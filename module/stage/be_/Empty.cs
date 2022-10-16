using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.staged.be_
{
	/// <summary>
	/// nothing to commit
	/// </summary>
	/// <remarks>
	/// Parsing the output of git status is a bad idea because the output is intended to be human readable, not machine-readable. There's no guarantee that the output will remain the same in future versions of nilnul.win.prog_.Git or in differently configured environments.
	/// UVVs comment is on the right track, but unfortunately the return code of git status doesn't change when there are uncommitted changes. It does, however, provide the --porcelain option, which causes the output of git status --porcelain to be formatted in an easy-to-parse format for scripts, and will remain stable across nilnul.win.prog_.Git versions and regardless of user configuration.
	/// </remarks>
	public class Empty
	{
		/// <summary>
		/// by checking the returned result.
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public bool Be_byStatus(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{

			var results = nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(gitTop, "status",git);
			var lines = nilnul.txts.fro_.txt_.split_._LineX.Line_removeWhite(results).ToArray();

			if (lines.Length == 2 && lines[1].Trim() == "nothing to commit, working tree clean")
			{
				return true;
			}
			return false;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// <remarks>
		/// If we do not care about untracked files in the working directory, we can use the --untracked-files=no option to disregard those:
		/// if [ -z "$(git status --untracked-files=no --porcelain)" ]; then 
		/// # Working directory clean excluding untracked files
		/// else 
		/// # Uncommitted changes in tracked files
		/// fi
		/// </remarks>
		static public bool Be_byStatusPorcelain(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{

			var results = nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(gitTop, "status --porcelain");
			if (results.Trim() == "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		///  git diff-index --quiet HEAD -- . may fail if there is no branch
		/// </summary>
		/// <returns></returns>
		/// <exception cref="">
		/// 
		/// </exception>
		///
		[Obsolete("if this is the initial commit (branch ref is not persisited on disk), then exception will be thrown: fatal: bad revision HEAD")]
		public static bool Be_DiffIndex(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{

			var results =nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(gitTop, "diff-index --quiet --cached HEAD --",git);	 // . is not necessary

			/*To check whether a repository has staged changes (not yet committed) use this:
git diff-index --quiet --cached HEAD --
•If it exits with 0 then there were no differences (1 means there were differences).
*/
			if (results.Trim() == "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool _Be_byDiffCached_ofAddress(string module, nilnul.win.prog_.Git git = null )
		{
			/*It's also worth noting that, although git status does not give meaningful exit code when the working directory is unclean, git diff provides the --exit-code option, which makes it behave similar to the diff utility, that is, exiting with status 1 when there were differences and 0 when none were found.

Using this, we can check for unstaged changes with:
git diff --exit-code

and staged, but not committed changes with:
git diff --cached --exit-code

Although git diff can report on untracked files in submodules via appropriate arguments to --ignore-submodules, unfortunately it seems that there is no way to have it report on untracked files in the actual working directory. If untracked files in the working directory are relevant, git status --porcelain is probably the best bet.
*/

			return nilnul.win.prog_.git.run._ExitCodeX._ExitCode_ofAddress(module,"diff --cached --quiet --exit-code",git)==0;
		}

		static public bool Be(nilnul.fs.folder_.git_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_byDiffCached_ofAddress(gitTop.ToString(), git);
		}

		static public bool Be(nilnul.fs.folder_.git_.work_.Top gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_byDiffCached_ofAddress(gitTop.ToString(), git);
		}

		static public bool Be(nilnul.fs.FolderI gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_byDiffCached_ofAddress(gitTop.ToString(), git);
		}

		static public bool Be(nilnul.fs.address_.ShieldI gitTop, nilnul.win.prog_.Git git = null)
		{
			return _Be_byDiffCached_ofAddress(gitTop.ToString(), git);
		}




	}
}
