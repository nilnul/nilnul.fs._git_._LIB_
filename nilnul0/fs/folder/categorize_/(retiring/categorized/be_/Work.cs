using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorized.be_
{
	public class Work : BeI
	{
		public bool be(Categorized obj)
		{
			return obj.type == _categorized.PlainWorkRepo.Work;

			//throw new NotImplementedException();
		}


		static public readonly Work Singleton = SingletonByDefault<Work>.Instance;

	}
}
