using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;


namespace nilnul.fs.folder_.nonlink_.giT_.plain0depobase.div_.nonlink_.giT_
{
	//extern alias bit;

	/// <summary>
	/// in and side. self is considered.
	/// </summary>
	static public class _DepobasesX
	{
		public static IEnumerable<DivI> _Divs_assumeNonlinkPlain0depobase(nilnul.fs.FolderI manable, win.prog_.Git git = null)
		{

			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(manable, git)
			)
			{

				case folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					return nilnul.fs.folder_.nonlink_.giT_.plain.div_.nonlink_.giT_._DepobasesX._Divs(manable);
					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					//must be nonbare, as the folder is plain0depobase
					return new DivI[] { new Div() };
					break;
				default:

					return nilnul.fs.folder_.nonlink_.giT_.work_.top.div_.nonlink_.giT_._DepobasesX._Divs(manable);
					break;
			}

		}

		public static IEnumerable< DivI> _Divs_assumeNonlinkPlain0depobase(ShieldI folder_nonLink, Git git)
		{
			return _Divs_assumeNonlinkPlain0depobase(new fs.Folder(folder_nonLink),git);


		}

		public static IEnumerable<DivI> _Divs_assumePlain0depobase(nilnul.fs.folder_.Normal manable, win.prog_.Git git = null)
		{

			return _Divs_assumeNonlinkPlain0depobase(manable.en,git);

		}


		public static IEnumerable<DivI> Divs(nilnul.fs.folder_.Normal manable, win.prog_.Git git = null)
		{
			var category = nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(manable.en);
			switch (category)
			{
				case folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Work:
					/*bit::*/nilnul.bit.vow_.True1.Vow(
						nilnul.fs.folder.be_.git_.work_.Top.Singleton.be( manable.en)
					);
					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					/*bit::*/nilnul.bit.vow_.True1.Vow(
						nilnul.fs.folder.be_.giT_.repo_.bare_._TopX.Be(manable.en)
					);
					break;
				default:
					break;
			}


		

			return _Divs_assumePlain0depobase(manable,git);

		}


		public static IEnumerable<DivI> _Divs_assumePlain0depobase(nilnul.fs.FolderI _folder_nonlink_plain0depoRt, win.prog_.Git git = null)
		{

			//nilnul.fs.folder.be_.normal.Vow.Singleton.vow(manable.ee);


			return _Divs_assumePlain0depobase(new folder_.Normal(_folder_nonlink_plain0depoRt),git);
			

		}
		public static IEnumerable<DivI> _Divs_assumePlain0depobase(address_.ShieldI _folder_nonlink, win.prog_.Git git = null)
		{
			return _Divs_assumePlain0depobase(new nilnul.fs.Folder(_folder_nonlink), git);
		}

		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> _Shields_assumePlain0depobase(address_.ShieldI work, win.prog_.Git git = null)
		{
			return _Divs_assumePlain0depobase(work, git).Select(x => new nilnul.fs.address_.shield_.BaseDiv(work, x));

		}
		static public IEnumerable<nilnul.fs._address.DivI> _Divs_assumeAddressPlain0depobase(
			string work
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Divs_assumePlain0depobase(nilnul.fs.address_.shield_._AddressX1.Create(work), git);

		}

	}
}
