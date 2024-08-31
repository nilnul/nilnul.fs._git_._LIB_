using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.tags_
{
	static public class _VeredX
	{
		static public IEnumerable<nilnul.txt_.Vered3> _Vereds_0depo(
			string module
			,
			nilnul.win.prog_.Git git=null
		) {

			return nilnul.fs.git.depo.repo.tags._VwX._Names_0depo(module, git).Select(
				x=> nilnul.txt_.Vered3.Parse(x)
			);
		}

		static public IEnumerable<nilnul.txt_.Vered3> _Vereds_0depo(
			string module
			, 
			string _nob
			,
			nilnul.win.prog_.Git git=null
		) {

			return _Vereds_0depo(module, git).Where(
				b=>b.nom.ee == _nob
			);
		}


	}
}
