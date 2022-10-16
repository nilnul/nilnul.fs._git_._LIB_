using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorized.be_
{
	public class Work1 : BeI1
	{
		public bool be(CategorizedOfLocation obj)
		{
			return obj.type == _categorized.PlainWorkRepo.Work;

			//throw new NotImplementedException();
		}


		static public readonly Work1 Singleton = SingletonByDefault<Work1>.Instance;

	}
}
