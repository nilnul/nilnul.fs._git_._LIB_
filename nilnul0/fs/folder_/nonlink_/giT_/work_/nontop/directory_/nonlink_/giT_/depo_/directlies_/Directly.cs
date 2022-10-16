using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.git_.work_.nontop.git_.modules_.nonlink_.interior_
{
	/// <summary>
	/// depots directly under
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs.folder_.nonlink_.giT_.work_.nontop.directory_.nonlink_.giT_.depo_._DirectliesX))]
	public static class _DirectlyX
	{
		public static IEnumerable<nilnul.fs._address.DirectoryI> _Directories(
			nilnul.fs.FolderI _nontop_nonlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				_address.DirI child in nilnul.fs.folder.dirs_._NonlinkX.Dirs(
					
					_nontop_nonlink
					
				)
			)
			{
				var childAddress = new nilnul.fs.folder_.ParentDir(_nontop_nonlink, child);

				if (
					nilnul.fs.folder_.git_.work.be_._TopX._Be(
						childAddress
					)
				)
				{
					yield return new nilnul.fs._address.Directory(child);
				}
				else  //nontop_.work
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

		public static IEnumerable<nilnul.fs._address.DirectoryI> _Directories(
			nilnul.fs.address_.ShieldI _nontop_nonlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Directories( new nilnul.fs.Folder(_nontop_nonlink),git);
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
