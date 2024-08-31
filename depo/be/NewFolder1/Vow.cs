using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.be
{
	public class Vow<TBe>:nilnul.be.Vow<ModuleI,TBe>
		,
		VowI
		where TBe:nilnul.BeI<ModuleI>,new()
	{
	}
}
