using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module
{
	public class Fetch_Head
	{




		/*
		  FETCH_HEAD is a short-lived ref, to keep track of what has just been fetched from the remote repository. git pull first invokes git fetch, in normal cases fetching a branch from the remote; FETCH_HEAD points to the tip of this branch (it stores the SHA1 of the commit, just as branches do). git pull then invokes git merge, merging FETCH_HEAD into the current branch.

The result is exactly what you'd expect: the commit at the tip of the appropriate remote branch is merged into the commit at the tip of your current branch.

This is a bit like doing git fetch without arguments (or git remote update), updating all your remote branches, then running git merge origin/<branch>, but using FETCH_HEAD internally instead to refer to whatever single ref was fetched, instead of needing to name things.

		

2

down vote
 

As mentioned in Jonathan's answer, FETCH_HEAD corresponds to the file .git/FETCH_HEAD. Typically, the file will look like this:
71f026561ddb57063681109aadd0de5bac26ada9                        branch 'some-branch' of <remote URL>
669980e32769626587c5f3c45334fb81e5f44c34        not-for-merge   branch 'some-other-branch' of <remote URL>
b858c89278ab1469c71340eef8cf38cc4ef03fed        not-for-merge   branch 'yet-some-other-branch' of <remote URL>


Note how all branches but one are marked not-for-merge. The odd one out is the branch that was checked out before the fetch. In summary: FETCH_HEAD essentially corresponds to the remote version of the branch that's currently checked out.
 

		 */
	}
}
