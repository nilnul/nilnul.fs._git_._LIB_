using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.branch.merge_
{
	/*
	I used the answer from Paul Pladijs since now. I found out, you can do a "normal" merge, conflicts occur, so you do

git checkout --theirs <file>
to resolve the conflict by using the revision from the other branch. If you do this for each file, you have the same behaviour as you would expect from

git merge <branch> -s theirs
Anyway, the effort is more than it would be with the merge-strategy! (This was tested with git version 1.8.0)
*/
	class AllTheirs
	{
	}
}
