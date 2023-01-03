using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.current.assign_.snap_
{
	/// stackoverflow.com/questions/1282639/switch-git-branch-without-files-checkout 
	/// answered Jul 12, 2017 at 14:10
	/// Tino
	/// <summary>
	/// git checkout --detach
	///		or git switch --detach
	/// is the same as git checkout HEAD^{} which leaves the current branch behind and goes into "detached head state". So the next modification of HEAD no more affects any branch. Detaching HEAD does not affect the worktree nor the index.
	/// </summary>
	/// <remarks>
	/// would throw exception if there is no defaulted commit;
	/// </remarks>
	static public class _DefaultedX
	{

	}
}
