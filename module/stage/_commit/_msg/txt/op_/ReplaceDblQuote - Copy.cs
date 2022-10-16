using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.staged._commit._msg.txt.op_
{
	public class ReplaceDblQuote : nilnul.txt.OpI2
	{
		public string op(string par)
		{
			return par.Replace('"', '`');
		}


		static public ReplaceDblQuote Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<ReplaceDblQuote>.Instance;
			}
		}

	}
}
