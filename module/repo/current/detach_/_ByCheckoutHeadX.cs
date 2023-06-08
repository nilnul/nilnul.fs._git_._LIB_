using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.current.detach_
{
	static public class _ByCheckoutHeadX
	{
		static public void _Detach_addressAssumeModule(string _addressAssumeModule, nilnul.os.prog_.Git git=null) {
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
				_addressAssumeModule
				,
				"checkout @" // don't use checkout HEAD; rather use "@",or else some error happens;
				,
				git
			);
		}
	}
}
