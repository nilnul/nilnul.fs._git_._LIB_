using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.be
{
	public class Anto : nilnul.obj.be.Anto<nilnul.fs.git.ModuleI>
		,nilnul.fs.git.module.BeI
	{
		public Anto(nilnul.obj.BeI1<ModuleI> be) : base(be)
		{
		}

	}
}
