using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_._plainWorkRepo.ret.be_
{
	public class Plain : BeI
	{
		public bool be(Ret obj)
		{
			return obj == Ret.Plain;

			//throw new NotImplementedException();
		}

		static public Plain Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Plain>.Instance;
			}
		}



	}
}
