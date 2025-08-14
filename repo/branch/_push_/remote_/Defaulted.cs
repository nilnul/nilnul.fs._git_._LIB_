using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.branch._push_.remote_
{
	///git-scm.com/docs/git-push#_description
	/// <summary>
	/// When the command line does not specify where to push with the <repository> argument, branch.*{name}.remote configuration for the current branch is consulted to determine where to push. If the configuration is missing, it defaults to origin.
	/// 
	/// </summary>
	/// https://git-scm.com/docs/git-config#Documentation/git-config.txt-branchnameremote
	/// <remarks>
	///branch.<name>.pushRemote
	///When on branch<name>, it overrides branch.<name>.remote for pushing.It also overrides remote.pushDefault for pushing from branch<name>.When you pull from one place (e.g.your upstream) and push to another place (e.g.your own publishing repository), you would want to set remote.pushDefault to specify the remote to push to for all branches, and use this option to override it for a specific branch.
	/// </remarks>
	/// <!---->
	class Defaulted
    {
    }
}
