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
	static public class _InternalX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git=null)
		{
			///todo: to take into account that symlink may loop
			foreach (var div_directlyContained in _InnerDirectlyX._Divs(work))
			{
				var directlyContainedModuleShield = new nilnul.fs.address_.shield_.BaseDiv(work, div_directlyContained);

				foreach (
					var divInsideInternalModule in nilnul.fs.folder_.git_.work_.top.modules_._InsideX._Divs(
						directlyContainedModuleShield
						,
						git
					)
				)
				{
					yield return nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(div_directlyContained,divInsideInternalModule);
				}
				yield return div_directlyContained;
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
