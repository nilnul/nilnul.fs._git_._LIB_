using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.work.vow
{
	public class En<T> : nilnul.obj.vow.En<nilnul.fs.folder_.git_.Work, T>
		where T : nilnul.fs.folder_.git_.work.VowI, new()
	{
		public En(Work val) : base(val)
		{
		}
	}
}
