using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.be_
{
	[Obsolete(" note in this process, some files may be locked, so an infinite loop will happen", true)]
	static public class _UnlockedX
	{
		static public bool Be(ModuleI obj, nilnul.win.prog_.Git git=null)
		{
			//get the ".git" folder

			//contains any files locked.

			return nilnul.fs.folder.docs._NoneX.None(
				 nilnul.fs.git.module._DbX._Folder_assumeDbIsDir(obj, git)
				,
				doc => nilnul.fs._address.doc_._exted.ext.Eq.Singleton.eq(
					nilnul.fs._address.doc_.exted._ExtX.Ext(doc)
					,
					".lock"
				)
			);

		}


	}
	/// <summary>
	/// any files(such as index, head) are locked.
	/// </summary>
	///
	[Obsolete(" note in this process, some files may be locked, so an infinite loop will happen", true)]

	public class Unlocked :
		nilnul.win.prog_.git.Boxed
		,
		git.module.BeI
	{
		public Unlocked(Git val) : base(val)
		{
		}
		public Unlocked() : base(Git.StaticInstance)
		{

		}

		public bool be(ModuleI obj)
		{
			return _UnlockedX.Be(obj, boxed);
		}
	}

}
