using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.branch_.current.be_
{
	static public class _EmptyX
	{
		static public bool Be(nilnul.fs.folder_.git_.Top gitTop,nilnul.win.prog_.Git git=null) {
			var result= nilnul.win.prog_.git.run._ResultX.Result(gitTop,"log",git);
			//fatal: your current branch 'abc' does not have any commits yet

			var trimmed = result.msg.Trim();

			if (trimmed.StartsWith("fatal: your current branch") && trimmed.EndsWith("does not have any commits yet") )
			{
				return true;
			}
			return false;

		}
	}
}
