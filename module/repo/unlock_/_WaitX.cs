using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.unlock_
{
	/// <summary>
	/// wait for a given time , and then force unlock;
	/// </summary>
	static public  class _WaitX
	{

		static public  Task/*<bool>*/ _WaitAsTask_addressAssumeModule(string address, CancellationToken cancel, int interval=3*1000) {
			return fs.git.repo.unlock_._WaitX._WaitAsyn_addressAssumeRepo(
				 fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(address)
				 ,
				 cancel
				 ,
				 interval
			);

			

		}


	}
}
