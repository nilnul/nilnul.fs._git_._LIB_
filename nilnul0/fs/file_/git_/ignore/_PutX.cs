using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.git_.ignore
{
	static public class _PutX
	{
		static public void Put(nilnul.fs.address_.SpearI targetAddress, IEnumerable<string> blob)
		{
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(targetAddress))
			{
				_PatchX._OfSpear(targetAddress,blob);

			}
			else
			{
				_EnforceX.Make(targetAddress,blob);
			}
		}

	

		static public void Put(string targetAddress, IEnumerable<string> blob)
		{
			Put(targetAddress, blob);
		}


	}
}