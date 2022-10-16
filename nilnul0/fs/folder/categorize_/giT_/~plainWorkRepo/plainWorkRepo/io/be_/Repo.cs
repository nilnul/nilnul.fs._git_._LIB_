using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.plainWorkRepo.io.be_
{
	public class Repo : BeI
	{
		public bool be(Io obj)
		{
			return obj.type == _plainWorkRepo.Ret.Repo;

			//throw new NotImplementedException();
		}


		static public readonly Repo Singleton = SingletonByDefault<Repo>.Instance;

	}
}
