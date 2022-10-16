using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink.div_.giT_.modules_.nonlink_
{
	/// <summary>
	/// in and side
	/// </summary>
	///
	[Obsolete()]
	static public class _InsideX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI _folder_nonLink, win.prog_.Git git=null)
		{
			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(_folder_nonLink, git)
			)
			{

				case folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					return nilnul.fs.folder_.nonlink_.git_.plain.git_.modules_.nonlink_._InsideX._Divs(_folder_nonLink);

					break;
				case folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					if (nilnul.fs.git.repo.be_._BareX._Be(_folder_nonLink))
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
					return nilnul.fs.folder_.nonlink_.git_.work.git_.modules_.nonlink_._InsideX._Divs(_folder_nonLink);
					break;
			}

	
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
