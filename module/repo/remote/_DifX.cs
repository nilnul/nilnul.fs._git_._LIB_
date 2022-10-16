using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote
{
	/*
> git status
If the output is

# On branch master
nothing to commit, working directory clean
Then you have pushed the current commit.

If the output instead begins with

# On branch master
# Your branch is ahead of 'origin/master' by 1 commit.
#   (use "git push" to publish your local commits)
Then you have a local commit that has not yet been pushed. You see this because the remote branch, origin/master, points to the commit that was last pushed to origin. However, your branch is ahead of 'origin/master', meaning that you have a local commit that has been created after the last pushed commit.

If the commit you are interested in is not the latest, then you can do

> git log --decorate --oneline
to find out if the commit in question is before or after the commit pointed to by origin/master.
If the commit is after (higher up in the log than) origin/master, then it has not been pushed.
*/
	static public class _DifX
	{
	}
}
