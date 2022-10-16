using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink.dir_.nonlink_.giT_
{

	///todo: plinq
	///todo: excluding items dynamic such that .csproj (or other items) folders's sub folder "obj", "bing", "packages", etc are excluded.
	/// <summary>
	/// in and side
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	static public class _ManablesX
	{
		public static IEnumerable<DirI> _Dirs_assumeNonlink(address_.ShieldI _nonLink, win.prog_.Git git=null)
		{

			return
				nilnul.fs.folder.dirs_._NonlinkX.Dirs(_nonLink).Where( d=> nilnul.fs.folder.dir.be_.giT_._ManableX.Be(
					_nonLink,
					d
					,git
				)
			) 
			;

	
		}
		static public IEnumerable<nilnul.fs._address.DirI> _Dirs_assumeAddressNonlink(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Dirs_assumeNonlink( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}
		public static IEnumerable<DirI> Dirs(nilnul.fs.folder_.Normal _nonLink, win.prog_.Git git=null)
		{

			return _Dirs_assumeNonlink(_nonLink.en.address.en,git);

	
		}

		public static IEnumerable<DirI> Dirs(ShieldI shield, Git git)
		{
			return Dirs(new Normal(shield) );
		}


		public static IEnumerable<nilnul.fs.address_.shield_.BaseDir> Shields(address_.ShieldI work, win.prog_.Git git = null)
		{
			return Dirs(work, git).Select(x => new nilnul.fs.address_.shield_.BaseDir(work, x));

		}

		static public IEnumerable<nilnul.fs._address.DirI> Dirs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			
			return Dirs( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}

	}
}
