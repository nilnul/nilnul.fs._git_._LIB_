using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.work_.nontop.directory_.nonlink_.giT_.depo_
{
	/// <summary>
	/// directory_.depots directly (not in another depo that is under) under given folder.
	/// </summary>
	public static class _DirectliesX
	{
		public static IEnumerable<nilnul.fs._address.DirectoryI> _Directories(
			nilnul.fs.FolderI _nonlink_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (
				_address.DirI child in nilnul.fs.folder.dirs_._NonlinkX.Dirs(

					_nonlink_nontop

				)
			)
			{
				var childAddress = new nilnul.fs.folder_.ParentDir(_nonlink_nontop, child);

				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(childAddress))
				{
					//case folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					//	break;
					case folder.categorize_.git_._plainWorkRepo.Ret.Work:
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

						break;
					case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
						yield return new nilnul.fs._address.Directory(child);
						break;
					default:
						throw new UnexpectedReachException($"{childAddress} is expected to be work or repo_.bare");
						break;
				}

			}

		}

		public static IEnumerable<nilnul.fs._address.DirectoryI> _Directories(
			nilnul.fs.address_.ShieldI _nontop_nonlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Directories(new nilnul.fs.Folder(_nontop_nonlink), git);
		}



		public static IEnumerable<nilnul.fs._address.DirectoryI> Directories(
			nilnul.fs.folder_.git_.work_.Nontop nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Directories(nontop.en.en.address.en, git);

		}
	}
}
