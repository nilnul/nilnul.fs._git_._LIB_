using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.doc_
{
	static public class _IgnoreX
	{
		static public new nilnul.fs.address_.spear_.ParentDoc Spear(nilnul.fs.git._module_.TopI top)
		{
			return new nilnul.fs.address_.spear_.ParentDoc(top.top.en.address.en.ToString() ,work.div.doc_.Ignore._DOC__TXT);
		}

		static public nilnul.fs.address_.SpearI Spear(nilnul.fs.git.ModuleI module) {
			return 
				div.doc_.Ignore.Spear(module.top1.en)
			;
		}

		static public string SpearTxt(nilnul.fs.git._module_.TopI top)
		{
			return Spear(top).ToString();
		}

		public static string SpearTxt_ofAddress(string top)
		{
			return SpearTxt(nilnul.fs.git.Module.FroAddress(top));
			//throw new NotImplementedException();
		}
		static public bool Exist(nilnul.fs.git.ModuleI module) {
			return nilnul.fs.address_.spear.be_.Occupied.Singleton.be(
				div.doc_.Ignore.Spear(module.top1.en)
			);
		}

	}
}
