using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.document
{
	public class _DifX
	{
		[Obsolete()]
		static public string  Dif(nilnul.win.prog_.Git git, string _module, string document)
		{
			return Dif(_module,document,git);
		}


		static public string Dif( string _module, string document, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_module,
				$"diff {document}"
				,git
			);
		}


	}
}
