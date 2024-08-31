using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote._fetch
{
	/// <summary>
	/// git config remote.origin.tagopt --tags
	/// </summary>
	/// <remarks>
	///Setting this value to --no-tags disables automatic tag following when fetching from remote . Setting it to --tags will fetch every tag from remote , even if they are not reachable from remote branch heads. Passing these flags directly to git-fetch(1) can override this setting. See options --tags and --no-tags of git-fetch(1).
	/// </remarks>
	internal class ICfg
	{
	}
}
