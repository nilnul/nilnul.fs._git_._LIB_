using nilnul.fs.folder_.git_;
using nilnul.win.process;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches
{
	[Obsolete()]
	static public class _VwX
	{
		static public _branches.CurrentAndRemaining Eval(nilnul.win.prog_.Git git, nilnul.fs.Folder workingDir)
		{

			var result = git.runCmd__returnResult(workingDir, "branch -a");



			if (result.beErr)
			{


				throw new _git.ReportErrException(result.err);
			}
			else
			{
				var outputBranches = result.msg.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

				var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));

				var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

				return new _branches.CurrentAndRemaining(
					nilnul.txt.Opt.CreateFroStr(defaultBranch)
					,
					nonDefaultBranch
				);
			}
		}

		public static object Eval(Top top, win.prog_.Git git)
		{
			throw new NotImplementedException();
		}

		static public _branches.CurrentAndRemaining Eval(nilnul.fs.Folder workingDir)
		{

			return Eval(nilnul.win.prog_.Git.StaticInstance, workingDir);
		}
		static public _branches.CurrentAndRemaining Eval(string workingDir)
		{

			return Eval(nilnul.fs.Folder.FroAddress(workingDir));
		}
		/*
		 git branch -a to view all(local and tracking) branches
		 
		 
		 */
	}
}
