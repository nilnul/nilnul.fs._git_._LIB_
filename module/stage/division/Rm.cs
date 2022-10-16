using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index.division
{
	static public class _RmX
	{
		/*
		 nilnul.win.prog_.Git rm will simply delete the file and add the deletion to the index. Meet: 
		 */

		/// <summary>
		/// rm --chached path
		/// </summary>
		public static void Exe(
			nilnul.fs.folder_.git_.Top module
			, nilnul.fs._address.DivisionI path
			, nilnul.win.prog_.Git git= null
		)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(module, "rm --cached "+ path.ToString());

		}
	}
}
