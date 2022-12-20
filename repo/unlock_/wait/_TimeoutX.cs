using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.unlock_.wait
{
	static public class _TimeoutX
	{
		static public async Task  _TimeoutAsyn_addressAssumeRepo(string address, int totalTime=30*1000, int interval=7*1000) {
			var cancelSrc = new CancellationTokenSource(totalTime);
			await _WaitX._WaitAsyn_addressAssumeRepo(address, cancelSrc.Token, interval);
		}


		[Obsolete(nameof(_TimeoutAsyn_addressAssumeRepo))]
		static public  Task  _TimeoutAsyn_ofAddress(string address, int totalTime=30*1000, int interval=7*1000) {
			return _TimeoutAsyn_addressAssumeRepo(address, totalTime, interval);
		}

		static public void _Timeout_addressAssumeRepo(string address, int totalTime = 30 * 1000, int interval = 7 * 1000)
		{
			_TimeoutAsyn_addressAssumeRepo(
			   address
			   ,
			   totalTime
			   ,
			   interval
		   ).Wait();
		}

	}
}
