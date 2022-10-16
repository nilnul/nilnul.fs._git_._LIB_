using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder.category.be_
{
	public class Repo : BeI
	{
		public bool be(Category obj)
		{
			return obj.type == _category.NoneWorkRepo.Repo;

			//throw new NotImplementedException();
		}


		static public readonly Repo Singleton = SingletonByDefault<Repo>.Instance;

	}
}
