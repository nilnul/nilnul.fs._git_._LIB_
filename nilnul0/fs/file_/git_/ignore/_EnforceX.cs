using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;

namespace nilnul.fs.file_.git_.ignore
{
	static public class _EnforceX
	{
		static public void Make(nilnul.fs.address_.SpearI targetAddress, string blob)
		{
			System.IO.File.WriteAllText(targetAddress.ToString(), blob);
		}

		static public void Make(nilnul.fs.address_.SpearI targetAddress, IEnumerable<string> blob)
		{
			Make(targetAddress, nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(blob));
		}

		static public void Make(string targetAddress,string blob)
		{
			Make( new nilnul.fs.address_.Spear(targetAddress) ,blob);
		}

		static public void Make(string targetAddress, IEnumerable<string> blob)
		{
			Make(targetAddress, nilnul.txt.accumulate_.join_._LineSeparatedX.ToWinLines(blob));
		}


	}
}