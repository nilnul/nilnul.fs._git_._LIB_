using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	/// <summary>
	/// reflog for module in that it contains detached commits which would be gc-ed later.
	/// log for repo in that it contains the commits.
	/// </summary>
	static public class _LogX
	{
		


		
	 /// <summary>
	 /// in blocks of details including author
	 /// </summary>
	 /// <param name="git"></param>
	 /// <param name="_module"></param>
	 /// <returns></returns>
		static public string Exe( nilnul.fs.folder_.git_.Top _module, nilnul.win.prog_.Git git=null)
		{
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(
				_module,
				"log"
			);
		}

	

	}
}
