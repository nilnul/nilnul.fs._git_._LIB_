using System;
using System.Collections.Generic;
using nilnul.fs._address;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.nonlink_.giT_.work_.top.div_.nonlink_.giT_
{
	/// <summary>
	/// including self and indirect ones
	/// </summary>
	public static class _DepobasesX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.FolderI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.obj.seq.op_.unary_._PrependX.Prepend( 
				new nilnul.fs._address.Div() ,

				work_.top.directory_.nonlink_.giT_._DeposX._Divs_assumeNonlinkWorkbase(_top,git)
				
			);

		}

		public static IEnumerable<nilnul.fs._address.DivI> _Divs(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs(new nilnul.fs.Folder(_top),git);

		}
	
	}
}
