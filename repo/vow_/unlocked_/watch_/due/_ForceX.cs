using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.vow_.unlocked_.watch_.due
{
	/// <summary>
	/// wait for a while, and forcefuly rename thence;
	/// </summary>
	///
	static public class _ForceX
	{
		static public async Task  _Asyn_0repo(string address, int totalTime=wait_._TimeoutX.TOTAL_TIME, int interval=_WaitAndSeeX.INTERVAL) {

			try
			{
				await _TimeoutX._Asyn_0repo(address, totalTime, interval);
			}

			catch (TaskCanceledException )
			{

				fs.git.repo._UnlockX._ByRename_addressAssumeRepo(address);
			}

		}



		static public void _Vod_0repo(string address, int totalTime = wait_._TimeoutX.TOTAL_TIME, int interval = _WaitAndSeeX.INTERVAL)
		{
			_Asyn_0repo(
			   address
			   ,
			   totalTime
			   ,
			   interval
		   ).GetAwaiter().GetResult();
		}
	}
}
