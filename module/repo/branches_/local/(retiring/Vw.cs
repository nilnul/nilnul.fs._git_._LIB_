using nilnul.win.process;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.repo.branches_.local
{
	[Obsolete(nameof(nilnul.fs.git.module.repo.branches_.local._VwX))]
	static public class _VwX
	{


		static public _branches.CurrentAndRemaining Vw(string workingDir)
		{

			var result = win.prog_.git.run.result._MsgX.OfAddress(workingDir, "branch");



			var outputBranches = result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

			var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));

			var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

			return new _branches.CurrentAndRemaining(
				nilnul.txt.Opt.CreateFroStr(defaultBranch)
				,
				nonDefaultBranch
			);
		}

		static public _branches.CurrentAndRemaining Vw(nilnul.fs.Folder workingDir)
		{

			var result = nilnul.win.prog_.git.run.result._MsgX.Msg(workingDir, "branch");



			var outputBranches = result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");

			var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));

			var nonDefaultBranch = outputBranches.Where(x => !x.StartsWith("*"));

			return new _branches.CurrentAndRemaining(
				nilnul.txt.Opt.CreateFroStr(defaultBranch)
				,
				nonDefaultBranch
			);
		}


	}
}
