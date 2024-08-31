using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.vow_.unlocked_.watch_
{
	public static class _TimeoutX
	{
		static public Task _AsTask_0depo(string address, int totalTime = 3*60 * 1000, int interval = 7 * 1000)
		{
			return fs.git.repo.vow_.unlocked_.watch_._TimeoutX._Asyn_0repo(
				fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(address)
				,
				totalTime
				,
				interval
			);
		}

		static public void _Vod_0depo(string address, int totalTime =3*60 * 1000, int interval = 2 * 1000)
		{
			 _AsTask_0depo(
				address
				,
				totalTime
				,
				interval
			).GetAwaiter().GetResult();
		}


	}
}
