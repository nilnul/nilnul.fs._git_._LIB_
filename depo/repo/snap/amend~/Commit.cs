using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.git.module
{
	/// <summary>
	/// the parents,
	/// the commiter,
	/// the message,
	/// the tree
	/// </summary>
	public class Commit
	{
		static public void _Amend(nilnul.win.prog_.Git git, string module)
		{
			git.runCmd_throwErr(
				module
				,
				$"commit --amend --no-edit"

				);
		}

		static public void _Amend( string module)
		{
			_Amend(nilnul.win.prog_.Git.StaticInstance, module);
		}


	}
}
