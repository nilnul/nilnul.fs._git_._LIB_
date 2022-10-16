using System;
using System.Collections.Generic;
using nilnul.fs._address;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.nonlink_.git_.work_.top.git_.modules_.nonlink_
{
	/// <summary>
	/// excluding self; including indirect ones
	/// </summary>
	public static class _InternalX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.FolderI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var internalDirectly in interior_._DirectlyX._Divs(_top,git))
			{
				var shield=   nilnul.fs.folder_._ParentDivisionX1.CreateFolder(_top, internalDirectly);
				foreach (
					var modulesContainedInInternalModules in _InsideX._Divs(shield, git)
				)
				{
					yield return nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(
						internalDirectly
						,
						modulesContainedInInternalModules
					);
				}
			}
		}

		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs( new nilnul.fs.Folder(_top),git);
		}
	}
}
