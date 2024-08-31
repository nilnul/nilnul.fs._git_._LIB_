using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.be_
{
	public class Unlink : BeI
	{
		public bool be(ModuleI obj)
		{
			return nilnul.fs.folder.be_.Normal.Singleton.be(obj.top.folder);
		}


		static public Unlink Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Unlink>.Instance;
			}
		}

	}
}
