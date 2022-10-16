using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.categorize_.git_._plainWorkRepo.ret.vow
{
	public class En<TVow> :
		nilnul.obj.vow.Ed<Ret, TVow>
		where TVow : VowI, new()
	{
		public En(Ret val) : base(val)
		{
		}
	}
}
