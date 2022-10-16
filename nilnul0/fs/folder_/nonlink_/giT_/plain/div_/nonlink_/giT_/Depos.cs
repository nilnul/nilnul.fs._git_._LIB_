using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.plain.div_.nonlink_.giT_
{
	/// <summary>
	/// in and side
	/// </summary>
	static public class _DepobasesX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git=null)
		{

			return folder_.nonlink_.giT_.plain.directory_.nonlink_.giT_._DepobasesX._Divs(work, git);
		}

		static public IEnumerable<nilnul.fs._address.DivI> _Divs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Divs( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}

		public static IEnumerable<DivI> _Divs(FolderI work, win.prog_.Git git=null)
		{
			return _Divs(work.address.en, git);

		}
	}
}
