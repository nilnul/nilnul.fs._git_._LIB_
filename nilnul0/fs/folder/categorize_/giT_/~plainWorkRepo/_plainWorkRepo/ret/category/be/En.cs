using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.folder.category.be
{
	public class En<TBe>:nilnul.be.Asserted<Category, TBe>
		where TBe:BeI,new()
	{

		public En(Category category):base(category)
		{

		}
	}
}
