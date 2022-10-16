using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_._plainWorkRepo.ret.be_
{
	[Obsolete("confusion. better use nonPlain")]
	public class Module : BeI
	{
		public bool be(Ret obj)
		{
			return obj == Ret.Work || obj== Ret.Repo;

			//throw new NotImplementedException();
		}

		static public Module Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Module>.Instance;
			}
		}



	}
}
