using nilnul.rel._has.re_.net_;
using nilnul.rel._has.re_.net_.poset_._contraster;
using nilnul.rel._has.re_.net_.poset_._contraster._contrast;
using nilnul.txt_.vered_.veR_.decs_.underlined.str.re_.contrast_;
using nilnul.txt_.vered_.veR_.decs_.underlined_.noM_.id_.ascii_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo._branch.name_._dnts.dnt_.segmented
{
	public class Contrast
		:

			nilnul.obj.Box1<
				nilnul.txt_.vered_.veR_.decs_.underlined.str.re_.contrast_.NulMin
			>
		,
		nilnul.rel._has.re_.net_.poset_._contraster.ContrastI<Segmented>
		,

		nilnul.rel._has.re_.net_.poset_._contraster.contrast._extrem_.MaxI<Segmented>
			
	{
		public Contrast() : base(nilnul.txt_.vered_.veR_.decs_.underlined.str.re_.contrast_.NulMin.Singleton)
		{
		}

		public 		Outlier contrast(Segmented x, Segmented y)
		{
			return boxed.contrast(
				x.Select(s => new txt_.vered_.veR_.decs_.Underlined(s.nom,s.ver) )
				,
				y.Select(s => new txt_.vered_.veR_.decs_.Underlined(s.nom,s.ver) )
			);
		}

		public IEnumerable<Segmented> max(IEnumerable<Segmented> set)
		{

			return boxed.max(
				set.Select(
					s=>s.Select(x=> new txt_.vered_.veR_.decs_.Underlined(x.nom,x.ver)  )
				)
				).Select(x=> new Segmented(x));
			//throw new NotImplementedException();
		}


		static public Contrast Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Contrast>.Instance;
			}
		}

	}
}
