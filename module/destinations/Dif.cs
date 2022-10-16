using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.destinations
{
	public class _DifX
	{
		[Obsolete()]
		static public string  Dif(nilnul.win.prog_.Git git, string _module)
		{
			return Dif(_module,git);
		}


		static public string Dif( string _module,nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module,
				$"diff"
				,git
			);

		}

	}
}
