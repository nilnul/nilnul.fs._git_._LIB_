using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.program_;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.git_.work_.top.modules_
{
	/// <summary>
	/// excluding self
	/// </summary>
	public static class _InnerX
	{
		public static IEnumerable<nilnul.fs._address.DivisionI> _Divisions(
			nilnul.fs.address_.ShieldI1 _top
			,
			nilnul.win.program_.Git git = null
		)
		{
			return  nilnul.fs.folder._DirsX1.Dirs(_top).Where(
					child =>
					nilnul.fs.git.module.dir.be_._WorkX1._Be(_top, child, git)
			).SelectMany(
				y=> nilnul.fs.git.module.dir_.work._InnerModuleSX._Divisions(_top,y,git)
			);

		}

		public static IEnumerable<DivisionI> _Divisions(FolderI3 en, win.program_.Git git=null)
		{
			return _Divisions(en.address.en,git);
		}

		//public static IEnumerable<nilnul.fs._address.DivisionI> Divisions(
		//	nilnul.fs.folder_.git_.work_.Nontop nontop
		//	,
		//	nilnul.win.program_.Git git = null
		//)
		//{
		//	return _Divisions(nontop.en.en.address.en,git);

		//}
	}
}
