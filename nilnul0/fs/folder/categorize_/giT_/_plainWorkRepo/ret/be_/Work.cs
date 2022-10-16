using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_._plainWorkRepo.ret.be_
{
	public class Work : BeI
	{
		public bool be(Ret obj)
		{
			return obj == Ret.Work;

			//throw new NotImplementedException();
		}


		static public Work Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Work>.Instance;
			}
		}


	}
}
