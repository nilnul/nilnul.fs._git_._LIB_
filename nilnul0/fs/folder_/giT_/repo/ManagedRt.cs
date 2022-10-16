using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.giT_.repo
{

	/// <summary>
	/// the module root if the repo is embedded, 
	/// the repo root if the repo is bare
	/// </summary>
	/// <remarks>
	/// managed RT
	/// </remarks>
	static public class _ManagedRtX
	{
		static public nilnul.fs.address_.ShieldI _Shield_assumeRepoAddress(string _repo)
		{
			return nilnul.fs.folder_.git_.repo.be_._BareX._Be_assumeRepoAddress(_repo)
				?
				nilnul.fs.folder_.giT_.repo.top_.byRevParse_._AbsX.Shield_assumeRepoAddress(_repo)
				:
				fs.folder_.git_.repo_.embeded ._ModuleRtX._Shield_assumeRepoEmbededAddress_byRepoTop(_repo);
		}

	}
}
