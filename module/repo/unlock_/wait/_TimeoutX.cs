using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.unlock_.wait
{
	public class _TimeoutX
	{
		static public Task _TimeoutAsTask_addressAssumeModule(string address, int totalTime = 3*60 * 1000, int interval = 7 * 1000)
		{
			return fs.git.repo.unlock_.wait._TimeoutX._TimeoutAsyn_addressAssumeRepo(
				fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(address)
				,
				totalTime
				,
				interval
			);
		}
		static public void _Timeout_addressAssumeModule(string address, int totalTime =3*60 * 1000, int interval = 7 * 1000)
		{
			 _TimeoutAsTask_addressAssumeModule(
				address
				,
				totalTime
				,
				interval
			).Wait();
		}


	}
}
