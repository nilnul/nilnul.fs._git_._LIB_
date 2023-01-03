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
	/// 
	/// git checkout --detach # <see cref="_DefaultedX"/>
	/// git reset --soft commitish #<see cref="current_.detached.assign_._UntoSnapX"/>
	/// 
	/// then moves HEAD to the SHA of the given commitish. If you want to update the index, too, leave --soft away, but I do not recommend to do so. This, again, does not touch the worktree, and (--soft) not the index.
	///
	/// git checkout commitish
	/// then attaches HEAD to the given commitish (branch) again. (If commitish is a SHA nothing happens.) This, too, does not affect index nor worktree.
	/// <summary>
	/// </summary>
	/// <remarks>
	/// would throw exception if there is no defaulted commit;
	/// </remarks>
	static public class _ByDetach9resetX
	{

	}
}
