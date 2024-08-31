using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module.branches_
{
	public class Seeded
	{


		static public string GetCurrentBranch(nilnul.win.prog_.Git git, string workingDir)
		{


			var result=nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(workingDir, "branch");



			var outputBranches = result.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Trim() != "");



			var defaultBranch = outputBranches.Where(x => x.StartsWith("*")).Select(y => y.TrimStart(' ', '*'));


			return defaultBranch.Single();


		}




	}
}
