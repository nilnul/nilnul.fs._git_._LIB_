using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_.plainWorkRepo.io.be_
{
	[Obsolete(nameof(None))]
	public class Plain : BeI
	{
		public bool be(Io obj)
		{
			return obj.type == _plainWorkRepo.Ret.Plain;

			//throw new NotImplementedException();
		}


		static public readonly Plain Singleton = SingletonByDefault<Plain>.Instance;

	}
}
