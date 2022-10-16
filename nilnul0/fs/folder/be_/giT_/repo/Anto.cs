using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.git_.repo
{
	public class Anto
		:nilnul.fs.folder.be.Anto<Repo>
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
