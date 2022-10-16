using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.git_.work_.top.modules_
{
	/// <summary>
	/// internal, excluding self
	/// </summary>
	public static class _InnerDirectlyX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return  nilnul.fs.folder._DirsX.Dirs(_top).Where(
					child =>
					nilnul.fs.git.module.dir.be_._WorkX._Be(_top, child, git)
			).SelectMany(
				y=> nilnul.fs.git.module.dir_.work.modules_._InsideDirectlyX._Divs(_top,y,git).Select
				(
					z=> nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(new nilnul.fs._address.Div( y)
					,
					z
					)
				)
			);

		}
		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> _Shields(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs(_top, git).Select(x=> new nilnul.fs.address_.shield_.BaseDiv(_top,x));
		}
		public static IEnumerable<DivI> _Divs(FolderI en, win.prog_.Git git=null)
		{
			return _Divs(en.address.en,git);
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
