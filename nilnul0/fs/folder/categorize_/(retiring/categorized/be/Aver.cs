using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.folder.categorized.be
{
	public class Aver<TBe>
		:nilnul.obj.be.Aver<Categorized,  TBe>
		where TBe: categorized.BeI ,new()
	{

	}
}
