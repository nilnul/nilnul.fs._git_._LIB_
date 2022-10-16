using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder.category.be
{
	public class Assertion<TBe>
		:nilnul.be.Assert_TbeDefault<Category,  TBe>
		where TBe:category.BeI ,new()
	{

	}
}
