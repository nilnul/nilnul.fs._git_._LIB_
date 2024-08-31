using System.Linq;

namespace nilnul.fs.git.module.repo.branch_.vered_.key.delNewIfSame
{
	/// <summary>
	/// if current is the branch to drop, this would fail;
	/// </summary>
	public static class _RetPrevIfDelElseNulX
	{
		public static nilnul.txt_.Vered PrevNulable(
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
				txt_.Vered last = sorted.Last();
				txt_.Vered secondLast = sorted[count - 2];
				if (
					//nilnul.fs.git.module.repo.branch.co.be_._DestinationsSameX.Be(module, last, secondLast)
					/// / some branch might be with no precedent history, as it might be created otherwise than by <see cref="stow._CreateX"/>
					///
					nilnul.fs.git.depo.repo.branch.re_._SameSnapX.Re(module, last, sorted[count - 2])

				)
				{
					nilnul.fs.git.module.repo.branch.drop_._ForceX.Drop(module, last, git);
					return secondLast;
				}
			}
			return null;
		}

		public static nilnul.txt_.Vered PrevNulable(
			nilnul.fs.git.ModuleI module
			,
			string branch

			,
			nilnul.win.prog_.Git git = null
		)
		{
			return PrevNulable(
				module
				,
				new nilnul.fs.git.repo._branch.name_._vered.Key(branch)

				,
				git
			);
		}

		public static nilnul.txt_.Vered PrevNulabe_ofModuleAddress(
			string module
			,
			string branch

			,
			nilnul.win.prog_.Git git = null
		)
		{
			return PrevNulable(
				nilnul.fs.git.Module.FroAddress(module)
				,
				(branch)

				,
				git
			);
		}


	}
}
