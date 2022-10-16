using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.be.anto_
{
	public class BeDefault<TBe>
		: nilnul.fs.git.module.be.Anto
		where TBe : nilnul.fs.git.module.BeI, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault<TBe>>.Instance;
			}
		}

	}
}
