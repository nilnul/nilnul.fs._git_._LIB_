﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.git_.plain.git_.modules_.nonlink_.internal_
{
	/// <summary>
	/// internal, not including self.
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs.folder_.nonlink_.giT_.plain.directory_.nonlink_.giT_.depo_._DirectliesX))]
	static public class _DirectlyX
	{
		public static IEnumerable<DivI> _Divs(nilnul.fs.FolderI _plain, win.prog_.Git git = null)
		{
			return nilnul.fs.folder.dirs_._NonlinkX.Dirs(_plain).SelectMany(
				x =>
					nilnul.fs.folder_.nonlink.git_.modules_.nonlink_.inside_._DirectlyX._Divs(
						new nilnul.fs.folder_.ParentDir(_plain, x)
					).Select(
						y => nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(new nilnul.fs._address.Div(x), y
					)
				)
			);
		}

		public static IEnumerable<DivI> _Divs(address_.ShieldI _plain, win.prog_.Git git = null)
		{
			return _Divs( new nilnul.fs.Folder(_plain),git);
		}

		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> _Shields(address_.ShieldI work, win.prog_.Git git = null)
		{
			return _Divs(work, git).Select(x=> new nilnul.fs.address_.shield_.BaseDiv(work, x));

		}
		static public IEnumerable<nilnul.fs._address.DivI> _Divs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Divs( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}

	}
}
