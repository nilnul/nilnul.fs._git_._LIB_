using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.unlock_
{
	/// <summary>
	/// wait for a given time , and then force unlock;
	/// </summary>
	static public  class _WaitX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="address"></param>
		/// <param name="canel"></param>
		/// <param name="interval"></param>
		/// <returns>
		/// if it is unlocked
		/// </returns>
		/// <exception cref="TaskCanceledException">
		/// if it's locked; per our testing, the throwed exception is <see cref="TaskCanceledException"/>, not aggregated when waited.
		/// </exception>
		static public async Task/*<bool>*/ _WaitAsyn_addressAssumeRepo(string address, CancellationToken canel, int interval=3*1000) {

			while (fs.git.repo.be_._LockenX._Be_assumeRepoAddress(address) )
			{
				//canel.ThrowIfCancellationRequested();
				await Task.Delay(interval,canel);
			}
			//return true;

		}




	}
}
