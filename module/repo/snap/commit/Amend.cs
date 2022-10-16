using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._commits_.commit
{
	/// <summary>
	/// the parents,
	/// the commiter,
	/// the message,
	/// the tree
	/// </summary>
	public class Amend
	{
		/// <summary>
		///  git commit --amend --no-edit amends a commit without changing its commit message. 
		/// </summary>
		/// <param name="git"></param>
		/// <param name="module"></param>
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
