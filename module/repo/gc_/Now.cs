namespace nilnul.fs.git.module.repo.gc_
{
	public static class _Up2NowX
	{
		/*
		 


git prune
		 */

		/*s described here, simply use 
git reflog expire --expire-unreachable=now --all
git gc --prune=now
git reflog expire --expire-unreachable=now --all removes all references of unreachable commits in reflog.
git gc --prune=now removes the commits themselves.
Attention: Only using git gc --prune=now will not work since those commits are still referenced in the reflog. Therefore, clearing the reflog is mandatory.*/

		/*git gc --prune=now, or low level git prune --expire now.*/


		public static string Report(
			nilnul.fs.git.ModuleI module
			,
			nilnul.win.prog_.Git git = null

		)
		{
			return nilnul.txt.op_.binary_.join_.DuoLineBreak.Singleton.op(

				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, "reflog expire --expire=all --all", git)
				,
				nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, "gc --prune=all", git)
			);

		}

		public static string Report_ofAddresses(
			string work
			
			,
			 nilnul.win.prog_.Git git = null
		)
		{
			return Report(
				nilnul.fs.git.Module.FroAddress(work)
				,git
			);
		}

	

	}
}
