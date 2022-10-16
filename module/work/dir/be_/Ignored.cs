using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.work.dir.be_
{
	static public class _IgnoredX
	{
		/*note: checking ".git" returns 0 */
		static public bool Be(nilnul.fs.git.ModuleI module, nilnul.fs._address.DirI _assumeNonRepoOfThisModule) {
			//var path = new nilnul.fs.address_.shield_.BaseDir(module.top1.en.address.en, _assumeNonRepoOfThisModule);


			var cod=nilnul.win.prog_.git.run_.timeout_.end._CodX.OfAddress(
				$"check-ignore --no-index -q {nilnul.txt.esc_.win_.Arg.Singleton.escape( _assumeNonRepoOfThisModule.denote)}"
				,
				module
			);

			return cod == 0;
		}
	}
}
