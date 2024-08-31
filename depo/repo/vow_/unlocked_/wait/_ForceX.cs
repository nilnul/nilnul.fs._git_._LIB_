using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.unlock_.wait
{
	public class _ForceX
	{
		static public Task _ForceAsTask_addressAssumeModule(string address, int totalTime = 30 * 1000, int interval = 7 * 1000)
		{
			return fs.git.repo.unlock_.wait._ForceX._ForceAsyn_addressAssumeRepo(
				fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(address)
				,
				totalTime
				,
				interval
			);
		}

		static public void _Timeout_addressAssumeModule(string address, int totalTime = 30 * 1000, int interval = 7 * 1000)
		{
			_ForceAsTask_addressAssumeModule(
			   address
			   ,
			   totalTime
			   ,
			   interval
		   ).Wait();
		}
	}
}
