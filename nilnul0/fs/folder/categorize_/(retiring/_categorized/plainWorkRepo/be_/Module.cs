using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.git.folder._categorized;

namespace nilnul.fs.git.folder._categorized.plainWorkRepo.be_
{
	public class Module :
		nilnul.fs.git.folder._categorized.plainWorkRepo.BeI
	{
		public bool be(PlainWorkRepo obj)
		{
			return obj == PlainWorkRepo.Work || obj == PlainWorkRepo.Repo;

			//throw new NotImplementedException();
		}


		static public readonly Module Singleton = SingletonByDefault<Module>.Instance;

	}
}
