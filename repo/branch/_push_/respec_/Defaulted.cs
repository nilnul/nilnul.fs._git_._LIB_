using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.branch._push_
{
	///git-scm.com/docs/git-push#_description
	/// <summary>
	/// When the command line does not specify what to push with<refspec>...arguments or --all, --mirror, --tags options, the command finds the default <refspec> by consulting remote.*.push configuration, and if it is not found, honors push.default configuration to decide what to push(See git-config[1] for the meaning of push.default).
	/// When neither the command-line nor the configuration specifies what to push, the default behavior is used, which corresponds to the simple value for push.default: the current branch is pushed to the corresponding upstream branch, but as a safety measure, the push is aborted if the upstream branch does not have the same name as the local one.
	/// </summary>
	/// https://git-scm.com/docs/git-config#Documentation/git-config.txt-branchnameremote
	/// <remarks>
	/// remote.<name>.push
	/// The default set of "refspec" for git-push[1]. See git-push[1].
	/// </remarks>
	class Defaulted
	{
	}
}
