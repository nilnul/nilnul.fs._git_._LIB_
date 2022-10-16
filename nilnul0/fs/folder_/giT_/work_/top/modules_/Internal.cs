﻿using System;
using System.Collections.Generic;
using nilnul.fs._address;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.git_.work_.top.modules_
{
	/// <summary>
	/// excluding self; including indirect ones
	/// </summary>
	public static class _InternalX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var internalDirectly in _InnerDirectlyX._Divs(_top,git))
			{
				var shield= new  nilnul.fs.address_.shield_.BaseDiv(_top, internalDirectly);
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

	
	}
}
