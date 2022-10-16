using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.git_.work.git_.modules_.nonlink_
{
	/// <summary>
	/// </summary>
	static public class _InteriorX
	{
		public static IEnumerable<DivI> _Divs(nilnul.fs.FolderI _work_nonlink, Git git=null)
		{
			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(_work_nonlink))
			{
				return  nilnul.fs.folder_.nonlink_.git_.work_.top.git_.modules_.nonlink_._InternalX._Divs(_work_nonlink,git);
			}
			else
			{
				return nilnul.fs.folder_.nonlink_.git_.work_.nontop.git_.modules_.nonlink_._InternalX._Divs(_work_nonlink, git);
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
