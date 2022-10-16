using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.git_.plain.modules_
{
	/// <summary>
	/// excluding self
	/// </summary>
	static public class _InsideDirectlyX
	{
		public static IEnumerable<DivI> _Divs(address_.ShieldI _plain, win.prog_.Git git=null)
		{

			return nilnul.fs.folder._DirsX.Dirs(_plain).SelectMany(
				x=> 
				
					nilnul.fs.folder.git_.modules_._InsideDirectlyX._Divs(
						new nilnul.fs.address_.shield_.BaseDir(_plain,x)
					).Select(
						y=> nilnul.fs._address.div.op_.binary_.Concat.Singleton.op(new nilnul.fs._address.Div(x),y
					)
				)
			);
			

		}
		

	}
}
