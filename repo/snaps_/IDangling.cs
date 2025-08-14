using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.snaps_
{
	///Commits that are (still) referenced by the reflog are considered reachable and not dangling.
	///Commits will be reachable via reflog for the gc.reflogExpire timespan, with a default of 90 days.
	/// <summary>
	/// To list dangling commits (commits that are unreachable from any branch or tag), use
	///		git fsck --unreachable
	/// </summary>
	/// 
	internal class IDangling
	{
	}
}
