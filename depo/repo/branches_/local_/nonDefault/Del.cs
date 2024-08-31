namespace nilnul.fs.git.module.repo.branches_.local_.nonDefault
{
	public static class _DelX
	{
		public static void Void(nilnul.fs.git.ModuleI module, nilnul.win.prog_.Git git = null)
		{

			nilnul.fs.git.module.repo.branches_.local_.nonDefault._VwX.Txts(module, git).ForEach(
				x =>
				{
					nilnul.fs.git.module.repo.branch_.local_.nonDefault._DropX._Drop(module, x, git);
				}
			)
			;
		}
		public static void Void(string module, nilnul.win.prog_.Git git = null)
		{
			Void(
				nilnul.fs.git.Module.FroAddress(module), git
			);
		}

	}
}
