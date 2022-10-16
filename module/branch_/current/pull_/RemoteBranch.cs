using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.branch_.current.pull_
{
	/// <summary>
	/// merge into current branch, even name differs.
	/// </summary>
	static public class _RemoteBranchX
	{
		

		static public void Pull( nilnul.fs.Folder folder, string remote, string branch, nilnul.win.prog_.Git git=null)
		{
			nilnul.win.prog_.git.run.result._Void_throwErrX.Void(folder, 
				$"pull {remote} {branch}"
				,git
			);
		}




	}
}
