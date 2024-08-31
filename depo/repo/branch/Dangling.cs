using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch
{
	/// <summary>
	/// upward to where a fork happens. delete the dangling will not detriment other paths leading to other branches.
	/// </summary>
	class Dangling
	{
		/*
		 git branch -a --contains 666bad
git tag --contains 666bad

Now delete them(tag/branch) all. You can either use git commands, or just go into .git/refs.

Do this on every computer that might have the file.

Make sure you are not in detached head.

Now we can kill all the commits, and therefore all the code, that is no longer referenceable (from this gitHub link):
git for-each-ref --format='delete %(refname)' refs/original | git update-ref --stdin
git reflog expire --expire=now --all
git gc --prune=now


Again, this should be done on each computer.

Finally, use this on each computer.

Note: 666bad is the first commit after evilbranch split from wherever it came from, i.e., the first commit that is only evilbranch.

		 
		 */
	}
}
