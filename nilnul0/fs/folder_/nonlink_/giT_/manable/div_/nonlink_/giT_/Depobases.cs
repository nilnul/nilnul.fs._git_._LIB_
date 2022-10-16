using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.manable.div_.nonlink_.giT_
{
	/// <summary>
	/// in and side. self is considered.
	/// </summary>
	static public class _DepobasesX
	{
		public static IEnumerable<DivI> _Divs_assumeNonlink(nilnul.fs.folder_.giT_.Manageable manable, win.prog_.Git git = null)
		{


			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(manable.ee, git)
			)
			{

				case folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					return					nilnul.fs.folder_.nonlink_.giT_.plain.div_.nonlink_.giT_._DepobasesX._Divs(manable.ee);
					//nilnul.fs.folder_.nonlink_.git_.plain.git_.modules_.nonlink_.inside_._DirectlyX._Divs(_folder_nonlink_plain0depo);

					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					//must be nonbare, as the folder is plain0depobase
					return new DivI[] { new Div() };

					//if (nilnul.fs.git.repo.be_._BareX._Be( _folder_nonlink_plain0depo))
					//{
					//}
					//else
					//{
					//	/// non bare repo
					//	return new DivI[0];
					//}
					break;
				default:

					return nilnul.fs.folder_.nonlink_.giT_.work_.top.div_.nonlink_.giT_._DepobasesX._Divs(manable.ee);
					break;
			}

		}

		public static IEnumerable< DivI> _Divs_assumeNonlink(ShieldI folder_nonLink, Git git)
		{
			return _Divs_assumeNonlink(new folder_.giT_.Manageable(folder_nonLink),git);


		}

		public static IEnumerable<DivI> Divs(nilnul.fs.folder_.giT_.Manageable manable, win.prog_.Git git = null)
		{

			nilnul.fs.folder.be_.normal.Vow.Singleton.vow(manable.ee);


			return _Divs_assumeNonlink(manable,git);

		}


		public static IEnumerable<DivI> Divs(nilnul.fs.FolderI _folder_nonlink_plain0depoRt, win.prog_.Git git = null)
		{






			return Divs(new folder_.giT_.Manageable(_folder_nonlink_plain0depoRt),git);
			

		}
		public static IEnumerable<DivI> Divs(address_.ShieldI _folder_nonlink, win.prog_.Git git = null)
		{
			return Divs(new nilnul.fs.Folder(_folder_nonlink), git);
		}

		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> Shields(address_.ShieldI work, win.prog_.Git git = null)
		{
			return Divs(work, git).Select(x => new nilnul.fs.address_.shield_.BaseDiv(work, x));

		}
		static public IEnumerable<nilnul.fs._address.DivI> Divs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Divs(nilnul.fs.address_.shield_._AddressX1.Create(work), git);

		}

	}
}
