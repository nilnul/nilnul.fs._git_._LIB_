using System.Linq;

namespace nilnul.fs.git.module.repo.branch_.vered_.nub_.newest_.noncurrent.retract_._toOrphan.fallback_
{
	/// <summary>
	/// if the prev is an orphan (a branch of only one snap)
	/// </summary>
	public static class _FallbackIfSameTree9OrphanX
	{
		public static bool DeletedOne(
					nilnul.fs.git.ModuleI module
					,
					nilnul.fs.git.repo._branch.name_._vered.Key branch
					,
					nilnul.win.prog_.Git git = null
				)
		{
			txt_.Vered[] sorted = branch_.vereds._SortX.Seq(module, branch, git).ToArray();

			int count = sorted.Length;//.Count()
			if (count >= 2)
			{
				var prev = sorted[count - 2];
				txt_.Vered last = sorted.Last();
				if (
					nilnul.fs.git.module.repo.branch.co.be_._DestinationsSameX.Be(module, last, prev)
					&&
					nilnul.fs.git.module.repo.branch.history.snaps.be_._PluralX.IsPlural(module,prev,git)


				)
				{
					nilnul.fs.git.module.repo.branch.drop_._ForceX.Drop(module, last, git);
					return true;
				}
			}
			return false;
		}

		public static bool DeletedOne(
			nilnul.fs.git.ModuleI module
			,
			string branch
		
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return DeletedOne(
				module
				,
				new nilnul.fs.git.repo._branch.name_._vered.Key(branch)
				
				,
				git
			);
		}

		public static bool DeletedOne_ofModuleAddress(
			string module
			,
			string branch
			
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return DeletedOne(
				nilnul.fs.git.Module.FroAddress(module)
				,
				(branch)
				
				,
				git
			);
		}


	}
}
