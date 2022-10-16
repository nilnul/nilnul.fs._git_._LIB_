using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash
{
	/// <summary>
	/// only tracked
	/// </summary>
	/// 
	[Obsolete("use Push")]
	public class _SaveX
	{
		




		/// <summary>
		/// same as: git stash save
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_module"></param>
		static public void _OfOnlyTracked(nilnul.win.prog_.Git git, string _module)
		{
			nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(
				_module
				,
				"stash"
			);
		}






		static public void _OfOnlyTracked( string _module)
		{
			 _OfOnlyTracked(nilnul.win.prog_.Git.StaticInstance, _module);
		}

		



	}
}
