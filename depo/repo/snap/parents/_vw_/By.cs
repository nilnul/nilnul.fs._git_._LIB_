using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.parents._vw_
{
	internal class By
	{
		/*
		 */

		/*
		 git rev-parse @^^@ works in cmd
			, where ^^ is escaped ^
			,where the last '@' means all parents.
			,where the first '@' means head.

		Be careful not to use <commit-ish>^, this will only show the first parent, not the parents.
		, @^ would be xpn if there is no parents.
		 */

		/*
		 git show -p @^^{} --pretty=%P --no-patch
		 */

	}
}
