using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.vow.ee_
{
	public class VowDefaulted<TVow> : depo.vow.Ee
		where TVow : VowI, new()
	{
		public VowDefaulted(in DepoI val) : base(
			val,
			
			 nilnul._obj.typ_._UnisonX<TVow>.Unison
		)
		{
		}

	

		public VowDefaulted(in string address) : base(address,  nilnul._obj.typ_._UnisonX<TVow>.Unison)
		{
		}
	}
}
