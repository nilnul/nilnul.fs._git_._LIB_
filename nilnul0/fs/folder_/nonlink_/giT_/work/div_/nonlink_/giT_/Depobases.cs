using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;

namespace nilnul.fs.folder_.nonlink_.giT_.work.div_.nonlink_.giT_
{
	/// <summary>
	/// </summary>
	static public class _DepobasesX
	{
		public static IEnumerable<DivI> _Divs_assumeNonlinkWork(nilnul.fs.FolderI _work_nonlink, Git git=null)
		{
			if (nilnul.fs.folder_.git_.work.be_._TopX._Be(_work_nonlink))
			{
				return  nilnul.fs.folder_.nonlink_.giT_.work_.top.div_.nonlink_.giT_._DepobasesX._Divs(_work_nonlink,git);
			}
			else
			{
				return nilnul.fs.folder_.nonlink_.giT_.work_.nontop.div_.nonlink_.giT_._DeposX._Divs_assumeNonlinkNontop(_work_nonlink, git);
			}

		}
		public static IEnumerable<DivI> _Divs_assumeNonlinkWork(address_.ShieldI work, win.prog_.Git git=null)
		{
			return _Divs_assumeNonlinkWork( new nilnul.fs.Folder(work),git );
		}


		static public IEnumerable<nilnul.fs._address.DivI> _Divs_assumeNonlinkWork(
			nilnul.fs.folder_.git_.Work work
			,
			nilnul.win.prog_.Git git=null
		) {
			return _Divs_assumeNonlinkWork(work.en.address.en,git);

		}

	}
}
