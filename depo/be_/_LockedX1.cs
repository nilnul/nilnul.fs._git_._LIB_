using nilnul.fs.address_;

namespace nilnul.fs.git.module.be_
{
	static public class _LockedX1
	{
		/// <summary>
		///
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// 
		static public bool Be(ModuleI obj)
		{
			//get the ".git" folder

			//contains any files locked.

			return nilnul.fs.git.repo.be_._LockenX.__Be_assumeRepobase(
				 nilnul.fs.git.module._RepoX.DefaultFolder(obj)
				
			);
		}

		public  static bool _Be_ofTop(ShieldI shield)
		{
			return Be( Module.OvTop(shield)); ;

		}

		static public bool _Be_ofTopAddress(string obj)
		{

			return Be( Module.FroAddress(obj)); ;

		}
	}
}
