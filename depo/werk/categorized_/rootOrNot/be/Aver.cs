using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.categorized_.rootOrNot.be
{
	public class Aver<TBe>
		:nilnul.obj.be.Aver<RootOrNot,  TBe>
		where TBe:rootOrNot.BeI,new()
	{
	}
}
