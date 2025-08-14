using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snaps_
{
	/// <summary>
	/// unreferenced. kept for a while due to possible "undo" demand. can be cleaned later.
	/// </summary>
	/// <remarks>
	/// they are in fact just stored in objects/ deserted. Hence intentionally, they are out of consideration;
	///
	/// </remarks>
	class IDangling
	{
		/*The important thing to remember with a detached HEAD is that if the commit it points to is otherwise unreferenced (no other ref can reach it), then it will become “dangling” when you checkout some other commit. Eventually, such dangling commits will be pruned through the garbage collection process (by default, they are kept for at least 2 weeks and may be kept longer by being referenced by HEAD’s reflog).*/
	}
}
