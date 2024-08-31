using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.vow_.unlocked_
{
	/// <summary>
	/// delay and check
	/// </summary>
	/// <remarks>
	/// for example, a plane to land needs to wait out the wake turbulence of the previous plane
	/// </remarks>
	static public  class _WaitAndSeeX
	{

		public const int INTERVAL = 3 * 1000;

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
		static public async Task/*<bool>*/ _Asyn_0repo(string address, CancellationToken canel, int interval=INTERVAL) {

			///as the caller is often concerned about the recent operation's latency, here we delay first to avoid the first unnecessry check;

			do await Task.Delay(interval, canel);
			while (fs.git.repo.be_._LockenX._Be_assumeRepoAddress(address));

		}






	}
}
