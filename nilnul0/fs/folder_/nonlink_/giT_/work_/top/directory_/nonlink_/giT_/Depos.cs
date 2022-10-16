using System;
using System.Collections.Generic;
using nilnul.fs._address;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.nonlink_.giT_.work_.top.directory_.nonlink_.giT_
{
	/// <summary>
	/// excluding self; including indirect ones
	/// </summary>
	public static class _DeposX
	{
		public static IEnumerable<nilnul.fs._address.DivI> _Divs_assumeNonlinkWorkbase(
			nilnul.fs.FolderI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			foreach (var dir in nilnul.fs.folder_.giT_.work_.top.dir_.nonlink_.giT_._NoEmbedRepoSX._Dirs_assumeWorkbase(_top,git))
			{
				var childAddress = new nilnul.fs.address_.shield_.BaseDir(_top.address.en, dir);
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(childAddress))
				{
					//case folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					//	break;
					case folder.categorize_.git_._plainWorkRepo.Ret.Work:
						foreach (var depo in nilnul.fs.folder_.nonlink_.giT_.work.div_.nonlink_.giT_._DepobasesX._Divs_assumeNonlinkWork(childAddress,git))
						{
							yield return  nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(
								dir
								,
								depo
							);
						}
						break;
					case folder.categorize_.git_._plainWorkRepo.Ret.Repo:

						yield return new nilnul.fs._address.Div( dir );
						break;
					
				}

			}

			
		}

		public static IEnumerable<nilnul.fs._address.DivI> _Divs_assumeNonlinkWorkbase(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs_assumeNonlinkWorkbase( new nilnul.fs.Folder(_top),git);
		}
	}
}
