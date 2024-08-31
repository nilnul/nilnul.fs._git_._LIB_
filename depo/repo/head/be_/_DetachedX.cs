using nilnul.fs.address_;

namespace nilnul.fs.git.module.repo.current.be_
{
	/// git status
	///		for human readable
	/// git branch
	///		for the first line
	/// <summary>
	/// the content of the HEAD file is a snap
	/// </summary>
	/// <remarks>
	/// anto to <see cref="IReferencing"/>
	/// </remarks>
	static public class _DetachedX
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

			return string.IsNullOrWhiteSpace(
				nilnul.os.prog_.git.run_.exit.result._MsgX.Msg(obj, "branch --show-current")
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
