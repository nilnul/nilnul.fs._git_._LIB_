using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.win.program_;

namespace nilnul.fs.git.module.dir_.work.modules_
{
	/// <summary>
	/// not including self
	/// </summary>
	static public class _InnerX
	{
		static public IEnumerable<nilnul.fs._address.DivisionI> _Divisions(
			nilnul.fs.git.ModuleI module
			,
			nilnul.fs._address.DirI2 dir
			,
			nilnul.win.program_.Git git=null
		) {
			return nilnul.fs.folder_.git_.work.modules_._InnerX.Divisions(
				new nilnul.fs.address_.shield_.ParentDir(module.top.en.address.en, dir)
				,
				git
			);
		}

		public static IEnumerable<DivisionI> _Divisions(
			nilnul.fs.address_.ShieldI1 top
			, 
			DirI2 dir
			, 
			win.program_.Git git
		)
		{
			return nilnul.fs.folder_.git_.work.modules_._InnerX.Divisions(
				new nilnul.fs.address_.shield_.ParentDir(top, dir)
				,
				git
			);
		}
	}
}
