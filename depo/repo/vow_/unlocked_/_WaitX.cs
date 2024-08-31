using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.vow_.unlocked_
{
	/// <summary>
	/// wait for a given time , and then force unlock;
	/// </summary>
	static public  class _WaitAndSeeX
	{

		static public  Task/*<bool>*/ _AsTask_0depo(string address, CancellationToken cancel, int interval=3*1000) {
			return fs.git.repo.vow_.unlocked_._WaitAndSeeX._Asyn_0repo(
				 fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(address)
				 ,
				 cancel
				 ,
				 interval
			);

			

		}


	}
}
