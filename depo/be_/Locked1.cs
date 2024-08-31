using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.be_
{

	/// <summary>
	/// any files(such as index, head) are locked.
	/// </summary>
	public class Locked1 : 
		
		git.module.BeI
	{
		

		public bool be(ModuleI obj)
		{
			return _LockedX1.Be(obj);
		}


		static public Locked1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Locked1>.Instance;
			}
		}

	}
}
