using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.be
{
	public class Anto : nilnul.obj.be.Anto_ofIn<nilnul.fs.git.DepoI>
		,nilnul.fs.git.depo.BeI
	{
	

		public Anto(BeI_ofIn<DepoI> be) : base(be)
		{
		}
	}
}
