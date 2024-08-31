using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.categorized_.rootOrNot.be_
{
	public class NonRoot
		: BeI
	{
		public bool be(RootOrNot obj)
		{
			return !obj.beRoot;
			
			//throw new NotImplementedException();
		}


	}
}
