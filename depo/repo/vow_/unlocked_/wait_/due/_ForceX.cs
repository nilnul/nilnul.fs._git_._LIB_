using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.vow_.unlocked_.wait_.due
{
	/// <summary>
	/// wait for a while, and forcefuly rename thence;
	/// </summary>
	///
	static public class _ForceX
	{
		static public  Task  _AsTask_0depo(
			string address
			, int totalTime=fs.git.repo.vow_.unlocked_.wait_._TimeoutX.TOTAL_TIME
			, int interval=fs.git.repo.vow_.unlocked_._WaitAndSeeX.INTERVAL
		) {

			return fs.git.repo.vow_.unlocked_.wait_.due._ForceX._Asyn_0repo(
				 fs.git.module._RepoX.DefaultAddress_worktopAssumeAddress(address)
				 ,
				 totalTime
				 ,
				 interval

			);
			//try
			//{
			//	await vow_.unlocked_.wait_._TimeoutX._AsTask_0depo(address, totalTime, interval);
			//}

			//catch (TaskCanceledException )
			//{
			//	fs.git.depo._UnlockX._ByRename_addressAssumeRepo(address);
			//}
		}

		static public void _Vod_0depo(
			string address, int totalTime = fs.git.repo.vow_.unlocked_.wait_._TimeoutX.TOTAL_TIME, int interval = fs.git.repo.vow_.unlocked_._WaitAndSeeX.INTERVAL
		)
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
