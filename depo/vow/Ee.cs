using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.vow
{
	public class Ee : nilnul.obj.vow.Ee_ofIn<DepoI>
		//where TVow : VowI, new()
	{
		public Ee(in DepoI val, in VowI vow) : base(val, vow)
		{
		}

		public Ee(in string address, in VowI vow):this(
			nilnul.fs.git.Module.FroAddress(address)
			,
			in vow
		)
		{
			
		}
	}
}
