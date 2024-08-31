using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;

namespace nilnul.fs.git.module.repo.snap_.current
{
	/// <summary>
	/// </summary>
	static public class _AmendX
	{
		static public void _Amend( string module, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				module
				,
				$"commit --amend --no-edit"

				);
		}

		
		





	}
}
