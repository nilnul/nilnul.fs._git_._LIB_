using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.dir_.work.modules_
{
	/// <summary>
	/// not including self
	/// </summary>
	static public class _InnerDirectlyX
	{
		static public IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.win.prog_.Git git=null
		) {
			return nilnul.fs.folder_.git_.work.modules_._InnerDirectlyX._Divs(
				new nilnul.fs.address_.shield_.BaseDir(module.top.en.address.en, dir)
				,
				git
			);
		}

		public static IEnumerable<DivI> _Divs(
			nilnul.fs.address_.ShieldI top
			, 
			DirI dir
			, 
			win.prog_.Git git
		)
		{
			return nilnul.fs.folder_.git_.work.modules_._InnerDirectlyX._Divs(
				new nilnul.fs.address_.shield_.BaseDir(top, dir)
				,
				git
			);
		}
	}
}
