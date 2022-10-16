using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stage
{
	/*
	 git ls-files --stage
	 */
	static public class _FilesX
	{
		static public string Show(string module) {

			return nilnul.win.prog_.git.run.result._MsgX.OfAddress(module, "ls-files");
		}
	}
}
