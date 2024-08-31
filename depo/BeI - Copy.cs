using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo
{
	public interface BeI
		:
		nilnul.obj.BeI_ofIn<DepoI>
	{
	}

	static public class BeX
	{
		static public bool Be( this BeI be, in string _depo) {
			return be.be(
				nilnul.fs.git.Module.FroAddress(_depo)
			);
		}
	}

	public abstract class BeA : BeI, _be_.OfAddressI
	{
		public abstract bool be(in DepoI val);

		public bool be(in string val)
		{
			return this.Be(in val);
		}
	}




}
