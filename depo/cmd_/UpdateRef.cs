using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.cmd_
{
	public class UpdateRef
	{

		/*
		 * 
		 * N.B. If you simply want to move a branch to another commit, this method is probably not the easiest option. branch -f as detailed by Chris Johnsen is a simpler command, so see his answer.

You can do it for arbitrary refs. This is how to move a branch pointer: 
git update-ref -m "reset: Reset <branch> to <new commit>" refs/heads/<branch> <commit>


The general form:
git update-ref -m "reset: Reset <branch> to <new commit>" <ref> <commit>


You can pick nits about the reflog message if you like - I believe the branch -f one is different from the reset --hard one, and this isn't exactly either of them.
*/
	}
}
