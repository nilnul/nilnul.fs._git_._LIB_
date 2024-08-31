using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.usr_.grp.repo
{
	/// docs.gitlab.com/ee/api/rest/index.html#namespaced-path-encoding
	/// 
	/// <summary>
	/// Namespaced path encoding
	/// If using namespaced API requests, make sure that the NAMESPACE/PROJECT_PATH is URL-encoded.
	/// For example, / is represented by %2F:
	/// GET /api/v4/projects/diaspora%2Fdiaspora
	/// A project’s path isn’t necessarily the same as its name. A project’s path is found in the project’s URL or in the project’s settings, under General > Advanced > Change path.
	/// </summary>
	internal class IPath
	{
	}
}
