using nilnul.fs.git.depo.repo.vow_.unlocked_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.vow_.unlocked_.wait_
{
	static public class _TimeoutX
	{
		public const int TOTAL_TIME = 60 * 1000;
		static public async Task _Asyn_0repo(string address, int totalTime=TOTAL_TIME, int interval=_WaitAndSeeX.INTERVAL) {
			var cancelSrc = new CancellationTokenSource(totalTime);
			await repo.vow_.unlocked_._WaitAndSeeX._Asyn_0repo(address, cancelSrc.Token, interval);
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="address"></param>
		/// <param name="totalTime"></param>
		/// <param name="interval"></param>
		/// <exception cref="System.Threading.Tasks.TaskCanceledException: 已取消一个任务。">
		/// if the lock doesnot disappear in a given time;
		/// to solve this, go to the repo, and delete any .lock files in .git/, or in .git/**/
		/// 
		/// </exception>
		static public void _Vod_0repo(string address, int totalTime = TOTAL_TIME, int interval = _WaitAndSeeX.INTERVAL)
		{
			_Asyn_0repo(
			   address
			   ,
			   totalTime
			   ,
			   interval
		   ).GetAwaiter().GetResult();//.Wait();
		}
	}
}