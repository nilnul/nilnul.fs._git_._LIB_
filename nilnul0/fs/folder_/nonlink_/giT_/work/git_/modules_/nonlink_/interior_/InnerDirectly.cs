using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.git_.work.modules_.nonlink_.interior_
{
	/// <summary>
	/// not including self
	/// </summary>
	static public class _DirectlyX
	{

		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git=null)
		{

			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(work,git))
			{
				return nilnul.fs.folder_.nonlink_.git_.work_.top.git_.modules_.nonlink_.interior_._DirectlyX._Divs(work,git);
			}
			else
			{
				return nilnul.fs.folder_.nonlink_.git_.work_.nontop.git_.modules_.nonlink_.interior_._DirectlyX._Directories(work, git).Select(x=>x.ToDiv());
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
