using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.vow
{
	public class En<TVow>:nilnul.vow.En<ModuleI,TVow>
		where TVow:VowI,new()
	{
		public En(ModuleI module):base(module)
		{

		}
	}
}
