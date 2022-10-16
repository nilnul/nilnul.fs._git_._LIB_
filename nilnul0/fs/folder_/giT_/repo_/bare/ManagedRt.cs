using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.repo_.bare
{
	/// <summary>
	/// upward to find the last shield that is still repo.
	/// <see cref="nameof(folder_.giT_.repo.top_.byRevParse_._AbsX)"/>
	/// </summary>
	public class _ManagedRtX
	{
		static public nilnul.fs.address_.ShieldI _Shield_ofAddress(string _embededRepo) {
			return nilnul.fs.address_.shield._SupsX.Sups_ofAddress(_embededRepo).Last(
				x => nilnul.fs.folder.be_.git_.Repo.Singleton.be(x)	//we suppos that a repo cannot be nested inside another repo (bare, or nonbare).
			);
		}
	}
}
