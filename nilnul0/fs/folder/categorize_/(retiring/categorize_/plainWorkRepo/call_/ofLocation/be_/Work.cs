using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorize_.plainWorkRepo.call_.ofLocation.be_
{
	public class Work : BeI
	{
		public bool be(OfLocation obj)
		{
			return obj.type == _plainWorkRepo.Ret.Work;

			//throw new NotImplementedException();
		}


		static public readonly Work Singleton = SingletonByDefault<Work>.Instance;

	}
}
