using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash.apply_
{
	/*Extra-advanced) You've used git stash save -p, or carefully git add-ed and/or git rm-ed specific bits of your code before running git stash save. You had one version in the stashed index/staging area, and another (different) version in the working tree. You want to preserve all this. So now you use git stash apply --index, and that sometimes fails with:
Conflicts in index.  Try without --index.
*/
	class _IndexX
	{

		/*you must run the git stash apply command with a --index option to tell the command to try to reapply the staged changes. If you had run that instead, you’d have gotten back to your original position:
$ git stash apply --index
# On branch master
# Changes to be committed:
#   (use "git reset HEAD <file>..." to unstage)
#
#      modified:   index.html
#
# Changes not staged for commit:
#   (use "git add <file>..." to update what will be committed)
#
#      modified:   lib/simplegit.rb
#*/


	}
}
