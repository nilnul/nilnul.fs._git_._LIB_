using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.workspace.category_.rootOrNot.be
{
	public class Assertion<TBe>
		:nilnul.be.Assert_TbeDefault<RootOrNot,  TBe>
		where TBe:rootOrNot.BeI,new()
	{
	}
}
