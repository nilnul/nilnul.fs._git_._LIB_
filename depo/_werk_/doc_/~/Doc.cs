using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git._module.work._ignore.div_.top
{
	[Obsolete(nameof(module.work.doc_._IgnoreX))]
	static public class _DocX
	{
		static public  new nilnul.fs.address_.spear_.ParentDoc Spear(nilnul.fs.git._module_.TopI top) {
			return new  nilnul.fs.address_.spear_.ParentDoc(top.top.en.address.en.ToString(), div._DocX.NAME);
		}

		static public  string SpearTxt(nilnul.fs.git._module_.TopI top) {
			return Spear(top).ToString();
		}

		public static string SpearTxt_ofAddress(string top)
		{
			return SpearTxt(nilnul.fs.git.Module.FroAddress(top));
			//throw new NotImplementedException();
		}

		
	}
}
