using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder.git_.modules_
{
	/// <summary>
	/// in and side
	/// </summary>
	static public class _InsideDirectlyX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git=null)
		{
			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(work,git)  
			)
			{

				case categorize_.git_._plainWorkRepo.Ret.Plain :
					return nilnul.fs.folder_.git_.plain.modules_._InsideDirectlyX._Divs(work);

					break;
				case categorize_.git_._plainWorkRepo.Ret.Repo :
					if (nilnul.fs.git.repo.be_._BareX._Be( work))
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
					return nilnul.fs.folder_.git_.work.modules_._InsideDirectlyX._Divs(work);
					break;
			}
			
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
