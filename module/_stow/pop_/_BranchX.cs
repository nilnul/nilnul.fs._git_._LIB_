using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash.pop_
{
	/*If you stash some work, leave it there for a while, and continue on the branch from which you stashed the work, you may have a problem reapplying the work. If the apply tries to modify a file that you’ve since modified, you’ll get a merge conflict and will have to try to resolve it. If you want an easier way to test the stashed changes again, you can run git stash branch, which creates a new branch for you, checks out the commit you were on when you stashed your work, reapplies your work there, and then drops the stash if it applies successfully:
$ git stash branch testchanges
Switched to a new branch "testchanges"
# On branch testchanges
# Changes to be committed:
#   (use "git reset HEAD <file>..." to unstage)
#
#      modified:   index.html
#
# Changes not staged for commit:
#   (use "git add <file>..." to update what will be committed)
#
#      modified:   lib/simplegit.rb
#
Dropped refs/stash@{0} (f0dfc4d5dc332d1cee34a634182e168c4efc3359)*/
	class _BranchX
	{

		/*This is what git stash branch is for.
If you:
check out the exact commit you were on when you did the original stash, then
create a new branch, and finally
git stash apply --index
the attempt to re-create the changes definitely will work. This is what git stash branch newbranch does. (And it then drops the stash since it was successfully applied.)*/


		/*Some final words about --index (what the heck is it?)
What the --index does is simple to explain, but a bit complicated internally:
When you have changes, you have to git add (or "stage") them before commiting.
Thus, when you ran git stash, you might have edited both files foo and zorg, but only staged one of those.
So when you ask to get the stash back, it might be nice if it git adds the added things and does not git add the non-added things. That is, if you added foo but not zorg back before you did the stash, it might be nice to have that exact same setup. What was staged, should again be staged; what was modified but not staged, should again be modified but not staged.
The --index flag to apply tries to set things up this way. If your work-tree is clean, this usually just works. If your work-tree already has stuff added, though, you can see how there might be some problems here. If you leave out --index, the apply operation does not attempt to preserve the whole staged/unstaged setup. Instead, it just invokes git's merge machinery, using the work-tree commit in the "stash bag". If you don't care about preserving staged/unstaged, leaving out --index makes it a lot easier for git stash apply to do its thing.*/
	}
}
