using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.repo_.bare
{
	[Obsolete(nameof(giT_.repo_.bare._ManagedRtX))]
	public class _ModuleRtX
	{
		static public nilnul.fs.address_.ShieldI _Shield_ofAddress(string _embededRepo) {
			return nilnul.fs.address_.shield._SupsX.Sups_ofAddress(_embededRepo).Last(
				x => nilnul.fs.folder.be_.git_.Repo.Singleton.be(x)	//we suppos that a repo cannot be nested inside another repo (bare, or nonbare).
			);
		}
	}
}
