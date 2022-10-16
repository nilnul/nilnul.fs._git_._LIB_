using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder.dir_.nonlink_.giT_
{
	/// <summary>
	/// in and side
	/// </summary>
	static public class _ManablesX
	{
		public static IEnumerable<DirI> _Dirs(address_.ShieldI work, win.prog_.Git git=null)
		{
			if (nilnul.fs.folder.be_.Normal.Singleton.be(work))
			{
				return nilnul.fs.folder_.nonlink.dir_.nonlink_.giT_._ManablesX.Dirs(work, git);
			}
			else
			{
				return new DirI[0];
			}

		}

		static public IEnumerable<nilnul.fs._address.DirI> _Dirs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Dirs( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}

	}
}
