using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.git_.work.modules_
{
	/// <summary>
	/// not including self
	/// </summary>
	static public class _InnerDirectlyX
	{

		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git=null)
		{

			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(work,git))
			{
				return nilnul.fs.folder_.git_.work_.top.modules_._InnerDirectlyX._Divs(work,git);
			}
			else
			{
				return nilnul.fs.folder_.git_.work_.nontop.modules_._InDirectlyX._Directories(work, git).Select(x=>x.ToDiv());
			}


		}
		static public IEnumerable<nilnul.fs._address.DivI> Divs(
			nilnul.fs.folder_.git_.Work work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Divs(work.en.address.en,git);

		}
	}
}
