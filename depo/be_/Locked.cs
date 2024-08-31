using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.be_
{
	[Obsolete(" note in this process, some files may be locked, so an infinite loop will happen",true)]
	static public class _LockedX
	{
		/// <summary>
		///
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// 
		static public bool Be(ModuleI obj, nilnul.win.prog_.Git git = null)
		{
			//get the ".git" folder

			//contains any files locked.

			return nilnul.fs.folder.docs._AnyX.Any(
				 nilnul.fs.git.module._DbX._Folder_assumeDbIsDir(obj, git)
				,
				doc => nilnul.fs._address.doc_._exted.ext.Eq.Singleton.eq(
					nilnul.fs._address.doc_.exted._ExtX.Ext(doc)
					,
					".lock"
				)
			);
		}

		public  static bool _Be_ofTop(ShieldI shield, Git git)
		{
			return Be( Module.OvTop(shield), git); ;

		}

		static public bool _Be_ofTopAddress(string obj, nilnul.win.prog_.Git git=null)
		{

			return Be( Module.FroAddress(obj), git); ;

		}
	}

	/// <summary>
	/// any files(such as index, head) are locked.
	/// </summary>
	[Obsolete(" note in this process, some files may be locked, so an infinite loop will happen", true)]
	public class Locked : 
		nilnul.win.prog_.git.Boxed
		,
		git.module.BeI
	{
		public Locked(Git val) : base(val)
		{
		}
		public Locked():base(Git.StaticInstance)
		{

		}

		public bool be(ModuleI obj)
		{
			return _LockedX.Be(obj,boxed);
		}
	}
}
