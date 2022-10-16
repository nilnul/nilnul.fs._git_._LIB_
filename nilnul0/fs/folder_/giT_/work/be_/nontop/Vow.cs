using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.work.be_.nontop
{
	public class Vow:nilnul.fs.folder_.git_.work.be.Vow<Nontop>,VowI
	{

		static public Vow Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow>.Instance;
			}
		}

	}
}
