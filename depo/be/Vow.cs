using nilnul.fs.address_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.be
{
	public class Vow :
		nilnul.obj.be.Vow_ofIn<DepoI>
		,
		fs.git.depo.VowI
		,
		fs.git.depo._vow_.OfAddressI
		,
		nilnul.obj.VowI_ofIn<DirectoryInfo>
	{
		public Vow(in BeI_ofIn<DepoI> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<DepoI> x) : base(x)
		{
		}

		public void vow(in string obj)
		{
			this.Vow(in obj);
		}

		public void vow(in DirectoryInfo obj)
		{
			this.Vow(in obj);
		}
	}
}
