using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.git_.repo
{

	/// <summary>
	/// the module root if the repo is embedded, 
	/// the repo root if the repo is bare
	/// </summary>
	/// <remarks>
	/// managed RT
	/// </remarks>
	///
	[Obsolete(nameof(giT_.repo._ManagedRtX))]
	public class CmdRt
	{
		static public nilnul.fs.address_.ShieldI _Shield_ofAddress(string _repo)
		{
			return nilnul.fs.folder_.git_.repo.be_._BareX._Be_ofAddress(_repo) ? nilnul.fs.folder_.git_.repo_.bare._ModuleRtX._Shield_ofAddress(_repo)
				:
				repo_.embeded._ModuleRtX._Shield_ofAddress(_repo);
		}

	}
}
