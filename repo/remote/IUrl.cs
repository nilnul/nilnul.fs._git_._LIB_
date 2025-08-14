using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.remote
{
	/// git-scm.com/docs/git-config#Documentation/git-config.txt-remotenameurl
	/// <summary>
	/// remote.<name>.url
	/// The URL of a remote repository. See git-fetch[1] or git-push[1]. A configured remote can have multiple URLs; in this case the first is used for fetching, and all are used for pushing (assuming no remote.<name>.pushurl is defined). Setting this key to the empty string clears the list of urls, allowing you to override earlier config.
	/// </summary>
    class IUrl
    {
    }
}
