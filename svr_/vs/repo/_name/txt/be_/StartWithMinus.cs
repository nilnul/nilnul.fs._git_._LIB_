using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.vs.repo._name.txt.be_
{
	public class StartWithMinus : nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return obj.StartsWith("-");
			//throw new NotImplementedException();
		}

		static public StartWithMinus Singleton
		{
			get
			{
				return nilnul.Singleton1<StartWithMinus>.Instance;
			}
		}

	}
}
