using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.work.div_.nonlink_.giT_.depo_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DirectliesX
	{
		public static IEnumerable<DivI> _Divs(nilnul.fs.FolderI _nonlink_work, Git git=null)
		{
			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(_nonlink_work))
			{
				return new[] { new nilnul.fs._address.Div() };
			}
			else
			{
				return nilnul.fs.folder_.nonlink_.giT_.work_.nontop.directory_.nonlink_.giT_.depo_._DirectliesX._Directories(_nonlink_work, git).Select(x => x.ToDiv());


					//nilnul.fs.folder_.nonlink_.git_.work_.nontop.git_.modules_.nonlink_.interior_._DirectlyX._Directories(_nonlink_work, git).Select(x => x.ToDiv());
			}

		}
		public static IEnumerable<DivI> _Divs(address_.ShieldI work, win.prog_.Git git=null)
		{
			return _Divs( new nilnul.fs.Folder(work),git );
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
