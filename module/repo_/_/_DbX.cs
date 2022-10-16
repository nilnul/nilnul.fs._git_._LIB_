using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.top
{
	[Obsolete()]

	static public class _DbX
	{
		/*
		 git rev-parse --git-dir
		 will show us ".git"
		 */
		static public string _Denote_ofTopAddress(string _top_address, nilnul.win.prog_.Git git=null) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.OfAddress(
				_top_address
				,
				"rev-parse --git-dir"
				,
				git
			);
		}
	}
}
