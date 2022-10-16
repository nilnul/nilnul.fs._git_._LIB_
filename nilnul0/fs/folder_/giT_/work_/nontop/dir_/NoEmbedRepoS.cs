using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.giT_.work_.nontop.dir_
{
	/// <summary>
	/// </summary>
	public static class _NoEmbedRepoSX
	{
		public static IEnumerable<nilnul.fs._address.DirI> _Dirs_assumeNontop(
			nilnul.fs.address_.ShieldI _nontop
		)
		{
			return nilnul.fs.folder._DirsX.Dirs(_nontop);

		}

		public static IEnumerable<DirI> _Dirs_assumeNontop(
			FolderI en
		)
		{
			return _Dirs_assumeNontop(en.address.en);
		}

		public static IEnumerable<nilnul.fs._address.DirI> Dirs(
			nilnul.fs.folder_.git_.work_.Nontop nontop
		)
		{
			return _Dirs_assumeNontop(nontop.en.en.address.en);

		}
	}
}
