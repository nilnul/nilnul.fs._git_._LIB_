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
	static public class _VwX1
	{
		static public _branches.CurrentAndRemaining Vw( nilnul.fs.folder_.git_.Top  workingDir, nilnul.win.prog_.Git git=null)
		{

			var result = nilnul.win.prog_.Git.RunCmd_result(workingDir, "branch -a",git);



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

		public static _branches.CurrentAndRemaining Vw(nilnul.fs.FolderI top, win.prog_.Git git=null)
		{
			return Vw(new Top(top),git);
		}

		
		static public _branches.CurrentAndRemaining Eval(string workingDir, win.prog_.Git git=null)
		{

			return Vw(nilnul.fs.Folder.FroAddress(workingDir),git);
		}
		/*
		 git branch -a to view all(local and tracking) branches
		 
		 
		 */
	}
}
