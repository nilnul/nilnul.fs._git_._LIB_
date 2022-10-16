using System;
using System.Collections.Generic;
using nilnul.fs._address;
using nilnul.win.prog_;
using System.Linq;
using System.Linq.Expressions;

namespace nilnul.fs.folder_.nonlink_.giT_.work_.top.directory_.nonlink_.giT_.depo_
{
	/// <summary>
	/// internal, excluding self
	/// </summary>
	public static class _DirectliesX
	{
		public static IEnumerable<nilnul.fs._address.DivI> __Divs_assumeNonlinkWorkbase(
			nilnul.fs.FolderI _top_nonlink
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return nilnul.fs.folder_.giT_.work_.top.dir_.nonlink_.giT_._NoEmbedRepoSX._Dirs_assumeWorkbase(
				_top_nonlink
			).SelectMany(
				y =>

				{
					var child = new nilnul.fs.folder_.ParentDir(
						_top_nonlink,
						y
					);

					switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(child))
					{
						case folder.categorize_.git_._plainWorkRepo.Ret.Repo:  //must  bare
							return new DivI[] { new _address.Div(y) };
							break;
						default: //must be work
							return nilnul.fs.folder_.nonlink_.giT_.work.div_.nonlink_.giT_._DepobasesX._Divs_assumeNonlinkWork(
								new nilnul.fs.folder_.ParentDir(
									_top_nonlink, y
								)
								, git
							).Select(
								z => nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(
									 y
									,
									z
								)
							);
						break;
					}
				}




			);

		}
		public static IEnumerable<DivI> __Divs_assumeNonlinkWorkbase(address_.ShieldI en, win.prog_.Git git = null)
		{
			return __Divs_assumeNonlinkWorkbase(new nilnul.fs.Folder(en), git);
		}

		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> _Shields_assumeNonlinkWorkbase(
			nilnul.fs.address_.ShieldI _top
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return __Divs_assumeNonlinkWorkbase(_top, git).Select(x => new nilnul.fs.address_.shield_.BaseDiv(_top, x));
		}



		public static IEnumerable<nilnul.fs._address.DivisionI> _Divs_assumeNonlink(
			nilnul.fs.folder_.git_.work_.Nontop nontop
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return __Divs_assumeNonlinkWorkbase(nontop.en.en.address.en, git);

		}
	}
}
