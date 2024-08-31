using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.branch.merge_
{
	/*
	For example:

git checkout branchA
git merge -X theirs branchB

Everything will merge in the desired way.

The only thing I've seen cause problems is if files were deleted from branchB. They show up as conflicts if something other than git did the removal.

The fix is easy. Just run git rm with the name of any files that were deleted:

git rm {DELETED-FILE-NAME}
After that, the -X theirs should work as expected.

Of course, doing the actual removal with the git rm command will prevent the conflict from happening in the first place.

Note: A longer form option also exists. To use it, replace:

-X theirs
with:

--strategy-option=theirs

edited Mar 1 at 22:08

Jason Aller
answered Jul 29 '10 at 15:58

Alan W. Smith
*/
	class TheirsOnlyIfConflict
	{
	}
}
