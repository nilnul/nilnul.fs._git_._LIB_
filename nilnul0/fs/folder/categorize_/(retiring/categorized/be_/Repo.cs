using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorized.be_
{
	public class Repo : BeI
	{
		public bool be(Categorized obj)
		{
			return obj.type == _categorized.PlainWorkRepo.Repo;

			//throw new NotImplementedException();
		}


		static public readonly Repo Singleton = SingletonByDefault<Repo>.Instance;

	}
}
