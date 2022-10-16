using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_._plainWorkRepo.ret.be_
{
	public class Repo : BeI
	{
		public bool be(Ret obj)
		{
			return obj == Ret.Repo;

			//throw new NotImplementedException();
		}

		static public Repo Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Repo>.Instance;
			}
		}



	}
}
