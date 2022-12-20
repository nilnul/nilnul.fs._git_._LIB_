using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.unlock_.wait
{
	static public class _ForceX
	{
		static public async Task  _ForceAsyn_addressAssumeRepo(string address, int totalTime=30*1000, int interval=7*1000) {

			var cancelSrc = new CancellationTokenSource(totalTime);
			try
			{
				await _WaitX._WaitAsyn_addressAssumeRepo(address, cancelSrc.Token, interval);


			}

			catch (TaskCanceledException )
			{

				fs.git.repo._UnlockX._ByRename_addressAssumeRepo(address);
			}
			//catch (OperationCanceledException )
			//{

			//	fs.git.module.repo._UnlockX._ByRename_moduleAssumeAddress(address);
			//}

		}

		[Obsolete(nameof(_ForceAsyn_addressAssumeRepo))]
		static public  Task  _ForceAsyn_ofAddress(string address, int totalTime=30*1000, int interval=7*1000) {

			return _ForceAsyn_ofAddress(address, totalTime, interval);

		}


		static public void _Timeout_addressAssumeRepo(string address, int totalTime = 30 * 1000, int interval = 7 * 1000)
		{
			_ForceAsyn_addressAssumeRepo(
			   address
			   ,
			   totalTime
			   ,
			   interval
		   ).Wait();
		}
	}
}
