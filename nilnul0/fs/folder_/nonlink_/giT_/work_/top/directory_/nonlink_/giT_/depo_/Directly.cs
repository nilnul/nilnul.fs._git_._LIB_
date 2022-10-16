using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.nonlink_.git_.work_.top.git_.modules_.nonlink_.interior_
{
	/// <summary>
	/// internal, excluding self
	/// </summary>
	///
	[Obsolete(nameof(
		nilnul.fs.folder_.nonlink_.giT_.work_.top.directory_.nonlink_.giT_.depo_._DirectliesX
		))]
	public static class _DirectlyX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.address_.ShieldI _top_nonlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return  nilnul.fs.git.module.dir_.work_._NonsymsX._Dirs(_top_nonlink).SelectMany(
				y=> nilnul.fs.folder_.nonlink_.git_.work.git_.modules_.nonlink_.inside_._DirectlyX._Divs
				(
					new nilnul.fs.folder_.ParentDir(
					_top_nonlink,y)
					,git
				).Select
				(
					z=> nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(
						 y
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
