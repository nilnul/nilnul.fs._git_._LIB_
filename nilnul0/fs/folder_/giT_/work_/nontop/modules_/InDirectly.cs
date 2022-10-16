using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.git_.work_.nontop.modules_
{
	/// <summary>
	/// modules directly under
	/// </summary>
	public static class _InDirectlyX
	{
		public static IEnumerable<nilnul.fs._address.DirectoryI> _Directories(
			nilnul.fs.address_.ShieldI _nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				_address.DirI child in nilnul.fs.folder._DirsX.Dirs(
					_nontop
				)
			)
			{
				var childAddress = new nilnul.fs.address_.shield_.BaseDir(_nontop, child);

				if (
					nilnul.fs.folder_.git_.work.be_._TopX._Be(
						childAddress
					)
				)
				{
					yield return new nilnul.fs._address.Directory(child);
				}
				else
				{
					foreach (
						var item in _Directories(
							childAddress
							,
							git
						)
					)
					{
						yield return nilnul.fs._address.directory.op_.binary_.Concat.Singleton.op(child, item);
					}
				}

			}

		}

		public static IEnumerable<DirectoryI> _Directories(FolderI en, win.prog_.Git git=null)
		{
			return _Directories(en.address.en,git);
		}

		public static IEnumerable<nilnul.fs._address.DirectoryI> Directories(
			nilnul.fs.folder_.git_.work_.Nontop nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Directories(nontop.en.en.address.en,git);

		}
	}
}
