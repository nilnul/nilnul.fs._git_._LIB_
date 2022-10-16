using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.git.folder._categorized;

namespace nilnul.fs.git.folder._categorized.plainWorkRepo.be_
{
	public class Plain :
		nilnul.fs.git.folder._categorized.plainWorkRepo.BeI
	{
		public bool be(PlainWorkRepo obj)
		{
			return obj == PlainWorkRepo.Plain;

			//throw new NotImplementedException();
		}


		static public readonly Plain Singleton = SingletonByDefault<Plain>.Instance;

	}
}
