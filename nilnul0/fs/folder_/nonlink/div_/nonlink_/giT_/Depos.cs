using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink.div_.nonlink_.giT_
{

	///todo: plinq
	///todo: excluding items dynamic such that .csproj (or other items) folders's sub folder "obj", "bing", "packages", etc are excluded.
	/// <summary>
	/// in and side
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	static public class _DeposX
	{
		public static IEnumerable<DivI> _Divs_assumeNonlink(address_.ShieldI _nonLink, win.prog_.Git git=null)
		{

			return nilnul.fs.folder.be_.giT_.Manageable.Ov(git).be(_nonLink)
				?
				 nilnul.fs.folder_.nonlink_.giT_.manable.div_.nonlink_.giT_._DepobasesX._Divs_assumeNonlink(

					 new nilnul.fs.folder_.giT_.Manageable(_nonLink)
				
				,
				git
				)
				:
				new DivI[0]
			;

	
		}
		static public IEnumerable<nilnul.fs._address.DivI> _Divs_assumeAddressNonlink(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Divs_assumeNonlink( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}
		public static IEnumerable<DivI> Divs(nilnul.fs.folder_.Normal _nonLink, win.prog_.Git git=null)
		{

			return _Divs_assumeNonlink(_nonLink.en.address.en,git);

	
		}

		public static IEnumerable<DivI> Divs(ShieldI shield, Git git)
		{
			return Divs(new Normal(shield) );
		}


		public static IEnumerable<nilnul.fs.address_.shield_.BaseDiv> Shields(address_.ShieldI work, win.prog_.Git git = null)
		{
			return Divs(work, git).Select(x => new nilnul.fs.address_.shield_.BaseDiv(work, x));

		}

		static public IEnumerable<nilnul.fs._address.DivI> Divs_ofAddress(
			string work
			,
			nilnul.win.prog_.Git git=null
		) {
			
			return Divs( nilnul.fs.address_.shield_._AddressX1.Create(work),git);

		}

	}
}
