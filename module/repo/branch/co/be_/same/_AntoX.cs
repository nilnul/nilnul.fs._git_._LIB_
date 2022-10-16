namespace nilnul.fs.git.module.repo.branch.co.be_.same
{
	public static class _AntoX
	{

		

		public static bool Be(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs.git.module.repo._branch.Name branch
			,
			nilnul.fs.git.module.repo._branch.Name branch1
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return !_DestinationsSameX.Be(module,branch,branch1,git);
		}

		public static bool Be(
			nilnul.fs.git.ModuleI module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Be(
				module
				,
				new _branch.Name(branch)
				,
				new _branch.Name(branch1)
				,
				git
			);
		}

		public static bool Be_ofModuleAddress(
			string module
			,
			string branch
			,
			string branch1
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Be(
				nilnul.fs.git.Module.FroAddress(module)
				,
				new _branch.Name(branch)
				,
				new _branch.Name(branch1)
				,
				git
			);
		}




	}
}
