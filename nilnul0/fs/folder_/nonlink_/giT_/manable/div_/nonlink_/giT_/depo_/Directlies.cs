using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.manable.div_.nonlink_.giT_.depo_
{
	/// <summary>
	/// in and side. self is considered. give the depo by giving the base of the depo
	/// </summary>
	static public class _DirectliesX
	{
		public static IEnumerable<DivI> _Divs_assumeNonlinkManable(nilnul.fs.FolderI _folder_nonlink_manable, win.prog_.Git git = null)
		{
			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(_folder_nonlink_manable, git)
			)
			{

				case folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					return nilnul.fs.folder_.nonlink_.giT_.plain.div_.nonlink_.giT_.depo_._DirectliesX._Divs(_folder_nonlink_manable);

					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo:   // no repo inner. so this is repo rt.

					return new[] { new nilnul.fs._address.Div() };  //this must be bare repo

					//if (nilnul.fs.git.repo.be_._BareX._Be( _folder_nonlink_manable))
					//{
					//}
					//else
					//{
					//	/// non bare repo
					//	return new DivI[0];
					//}
					break;
				default:

					return nilnul.fs.folder_.nonlink_.giT_.work.div_.nonlink_.giT_.depo_._DirectliesX._Divs(_folder_nonlink_manable);

					//return nilnul.fs.folder_.nonlink_.git_.work.git_.modules_.nonlink_.inside_._DirectlyX._Divs(_folder_nonlink_manable);


					break;
			}

		}


		public static IEnumerable<DivI> _Divs_assumeNonlinkManable(address_.ShieldI _folder_nonlink, win.prog_.Git git = null)
		{
			return _Divs_assumeNonlinkManable(new nilnul.fs.Folder(_folder_nonlink), git);
		}

		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> _Shields_assumeNonlinkManable(address_.ShieldI work, win.prog_.Git git = null)
		{
			return _Divs_assumeNonlinkManable(work, git).Select(x => new nilnul.fs.address_.shield_.BaseDiv(work, x));

		}
		static public IEnumerable<nilnul.fs._address.DivI> _Divs_ofAddress_assumeNonlinkManable(
			string work
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs_assumeNonlinkManable(nilnul.fs.address_.shield_._AddressX1.Create(work), git);

		}

		public static IEnumerable<DivI> _Divs_assumeNonlinkManable(nilnul.fs.folder_.nonlink_.giT_.Manable manable, win.prog_.Git git = null)
		{
			return _Divs_assumeNonlinkManable(manable.en, git);
		}
	}
		
}
