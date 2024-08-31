using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.address_.spear;
using nilnul.fs.file_.git_.ignore;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.giT_.ignore
{
	static public class _EnsureX
	{
		static public void _Ensure_0spear(string targetAddress, IEnumerable<string> blob)
		{
			if (System.IO.File.Exists(targetAddress))
			{
				_PatchX._Vod_0file(targetAddress,blob);

			}
			else
			{
				_EnforceX._Vod_0spear(targetAddress,blob);
			}
		}

		/// <summary>
		/// ensure
		/// </summary>
		/// <param name="targetAddress"></param>
		/// <param name="blob"></param>
		static public void Ensure(nilnul.fs.address_.SpearI targetAddress, IEnumerable<string> blob)
		{
			_Ensure_0spear(targetAddress.ToString(),blob);
		}

	



	}
}