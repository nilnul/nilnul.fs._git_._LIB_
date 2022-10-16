using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.work_.top
{
	public class Anto:nilnul.fs.folder.be.Anto<Top>
	{

		static public Anto Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
