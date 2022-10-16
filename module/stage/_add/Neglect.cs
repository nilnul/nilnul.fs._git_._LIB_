using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.index._add
{
	/*So, to temporarily ignore changes in a certain file, run:

git update-index --assume-unchanged <file>

Then when you want to track changes again:

git update-index --no-assume-unchanged <file>

Obviously there’s quite a few caveats that come into play with this. If you git add the file directly, it will be added to the index. Merging a commit with this flag on will cause the merge to fail gracefully so you can handle it manually.

Let’s go over a quick example of using the command. Changes have been made to a few files in my working directory:

$ git status
# On branch master
#
# Changed but not updated:
#   (use "git add <file>..." to update what will be committed)
#
#	modified:   README.textile
#	modified:   Rakefile
#	modified:   TODO
#
no changes added to commit (use "git add" and/or "git commit -a")
If I ran git commit -a from here, all of the files would be added into the new commit. However, I want to temporarily ignore the changes in one of the files:

$ git update-index --assume-unchanged README.textile   
$ git status
# On branch master
#
# Changed but not updated:
#   (use "git add <file>..." to update what will be committed)
#
#	modified:   Rakefile
#	modified:   TODO
#
no changes added to commit (use "git add" and/or "git commit -a")
So if we commit the work now then turn the flag off, we can see that nilnul.win.prog_.Git didn’t lose the original changes to the README. From there, you could now add them into a new commit, or revert back to the latest copy.

$ git update-index --no-assume-unchanged README.textile
$ git status
# On branch master
# Your branch is ahead of 'origin/master' by 4 commits.
#
# Changed but not updated:
#   (use "git add <file>..." to update what will be committed)
#
#	modified:   README.textile
#
no changes added to commit (use "git add" and/or "git commit -a")
Check out the man page for git update-index here. If you know of other clever tricks with the index, leave a comment or submit a tip!*/
	class Neglect
	{
	}
}
