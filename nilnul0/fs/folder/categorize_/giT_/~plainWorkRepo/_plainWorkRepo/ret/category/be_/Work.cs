using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder.category.be_
{
	public class Work : BeI
	{
		public bool be(Category obj)
		{
			return obj.type == _category.NoneWorkRepo.Work;

			//throw new NotImplementedException();
		}


		static public readonly Work Singleton = SingletonByDefault<Work>.Instance;

	}
}
