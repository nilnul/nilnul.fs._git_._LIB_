using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr.client._repo_
{
	public interface  BaseUrl4RepoI
	{
		/// <summary>
		/// basis stem for repo address, without cred info.
		/// this is useful to different repoSvc at different orgs at a same svr.
		/// </summary>
		string basis { get; }
	}
}
