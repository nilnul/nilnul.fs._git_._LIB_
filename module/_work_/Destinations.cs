using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_
{
	/// <summary>
	/// 
	/// </summary>
	public class Destinations
	{
		/*
		delete all files in the new working directory:
$ git rm -rf.

		*/

		static public void DeleteAll(string module,Git git=null) {
			nilnul.win.prog_.git.run.result._Void_throwErrX.OfAddress(module, "rm -rf", git);

		}

	}
}
