using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink.git_.modules_.nonlink_.inside_
{
	/// <summary>
	/// in and side. self is considered.
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs.folder_.nonlink_.giT_.manable.div_.nonlink_.giT_.depo_._DirectliesX))]
	static public class _DirectlyX
	{
		public static IEnumerable<DivI> _Divs(nilnul.fs.FolderI _folder_nonlink, win.prog_.Git git=null)
		{
			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(_folder_nonlink,git)  
			)
			{

				case folder.categorize_.git_._plainWorkRepo.Ret.Plain :

					return nilnul.fs.folder_.nonlink_.git_.plain.git_.modules_.nonlink_.inside_._DirectlyX._Divs(_folder_nonlink);

					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo :
					if (nilnul.fs.git.repo.be_._BareX._Be( _folder_nonlink))
					{
						return new[] { new nilnul.fs._address.Div() };
					}
					else
					{
						/// non bare repo
						return new DivI[0];
					}
					break;
				default:
					return nilnul.fs.folder_.nonlink_.git_.work.git_.modules_.nonlink_.inside_._DirectlyX._Divs(_folder_nonlink);
					break;
			}
			
		}
		public static IEnumerable<DivI> _Divs(address_.ShieldI _folder_nonlink, win.prog_.Git git=null)
		{
			return _Divs( new nilnul.fs.Folder(_folder_nonlink),git);
		}

		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> _Shields(address_.ShieldI work, win.prog_.Git git = null)
		{
			return _Divs(work, git).Select(x=> new nilnul.fs.address_.shield_.BaseDiv(work, x));

		}
		static public IEnumerable<nilnul.fs._address.DivI> _Divs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Divs( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}

	}
}
