using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.plain.directory_.nonlink_.giT_
{
	/// <summary>
	/// in and no side
	/// </summary>
	///
	//[Obsolete(nameof(fs.folder_.nonlink_.giT_.plain.directory_.nonlink_.giT_.depo_.) )]
	static public class _DepobasesX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git = null)
		{
			return nilnul.fs.folder.dirs_._NonlinkX.Dirs(work).SelectMany(
				x   // plain, depo(work or repo_.Bare).
				=>
				nilnul.fs.folder_.nonlink_.giT_.plain0depobase.div_.nonlink_.giT_._DepobasesX._Divs_assumeNonlinkPlain0depobase(
						new nilnul.fs.folder_.ParentDir(work, x)
					).Select(
						y => nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(new nilnul.fs._address.Div(x), y
					)
				)
			);


		}

		static public IEnumerable<DivI> _Divs(FolderI work, Git git)
		{
			return _Divs(work.address.en, git);

		}

		static public IEnumerable<nilnul.fs._address.DivI> _Divs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs(nilnul.fs.address_.shield_._AddressX1.Create(work), git);

		}

	}
}
