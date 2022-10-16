using System;
using System.Collections.Generic;
using nilnul.fs._address;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.nonlink_.giT_.work_.nontop.directory_.nonlink_.giT_
{
	/// <summary>
	/// excluding self; including indirect ones
	/// </summary>
	public static class _DepobasesX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs_assumeNonlinkNontop(
			nilnul.fs.FolderI _nonlink_nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var dir in nilnul.fs.folder.dirs_._NonlinkX.Dirs(_nonlink_nontop))
			{
				var childAddress = new nilnul.fs.address_.shield_.BaseDir(_nonlink_nontop.address.en, dir);
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(childAddress))
				{
					case folder.categorize_.git_._plainWorkRepo.Ret.Work:
						foreach (
							var depo in nilnul.fs.folder_.nonlink_.giT_.work.div_.nonlink_.giT_._DepobasesX._Divs_assumeNonlinkWork(
								childAddress
								,
								git
							)
						)
						{
							yield return nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(
								dir
								,
								depo
							);
						}
						break;
					case folder.categorize_.git_._plainWorkRepo.Ret.Repo: //must be bare
						yield return new nilnul.fs._address.Div(dir);
						break;
				}
			}
		}

		public static IEnumerable<nilnul.fs._address.DivI> _Divs_assumeNonlinkNontop(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs_assumeNonlinkNontop(new nilnul.fs.Folder(_top), git);
		}
	}
}