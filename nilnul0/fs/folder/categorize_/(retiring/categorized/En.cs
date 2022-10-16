using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorized
{
	public class En<TBe>:nilnul.obj.be.En_beDefaultable<Categorized, TBe>
		where TBe:BeI,new()
	{

		public En(Categorized category):base(category)
		{

		}
	}
}
