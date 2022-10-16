using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder.category.be_
{
	public class None : BeI
	{
		public bool be(Category obj)
		{
			return obj.type == _category.NoneWorkRepo.None;

			//throw new NotImplementedException();
		}


		static public readonly None Singleton = SingletonByDefault<None>.Instance;

	}
}
