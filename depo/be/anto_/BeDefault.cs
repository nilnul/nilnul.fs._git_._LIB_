using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.be.anto_
{
	public class BeDefault<TBe>
		: nilnul.fs.git.depo.be.Anto
		where TBe : nilnul.fs.git.depo.BeI, new()
	{
		public BeDefault() : base(
				 nilnul._obj.typ_._UnisonX<TBe>.Unison
			)
		{
		}

		static public BeDefault<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefault<TBe>>.Unison;
			}
		}
	}
}
