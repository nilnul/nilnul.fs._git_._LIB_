﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder.git_.modules_.nonlink_.inside_
{
	/// <summary>
	/// in and side
	/// </summary>
	static public class _DirectlyX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI _folder, win.prog_.Git git=null)
		{
			if (nilnul.fs.folder.be_.Normal.Singleton.be(_folder))
			{
				return nilnul.fs.folder_.nonlink.git_.modules_.nonlink_.inside_._DirectlyX._Divs(_folder, git);
			}
			else
			{
				return new DivI[0];
			}


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
