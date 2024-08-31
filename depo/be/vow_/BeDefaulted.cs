using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.be.vow_
{
	public class BeDefaulted<TBe>
		:
		Vow
		where TBe : nilnul.obj.BeI_ofIn<DepoI>, new()
	{
	

		public BeDefaulted() : base(
			nilnul._obj.typ_._UnisonX<TBe>.Unison
		)
		{
		}


		static public BeDefaulted<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefaulted<TBe>>.Unison;
			}
		}

	}
}
