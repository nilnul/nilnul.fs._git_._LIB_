using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.co_.tracked.be_
{
	static public class _PushedX
	{
		

		/*If you have made multiple commits and not sure which one of them have been pushed to remote, try this:
git log origin/<remote-branch>..<local-branch>
Example:
git log origin/master..master
This would list out all commits in your local branch that have not been pushed to the remote branch mentioned.*/
		static public bool ListCommits(
			nilnul.fs.git.repo._branch.Name branch
			,
			nilnul.fs.git.module.repo._cfg_._remote.Name remote
		)
		{
			///todo:

			throw new NotImplementedException();

		}



		/*Try this. git branch -r --contains <sha1>
For a commit in my repository I can see it exists on the remote develop branch
git branch  -r --contains 7914e54ea7e30c7f446e791df66bd3a5805c978a
origin/develop*/
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void TrackingContain(string[] args)
		{

		}

		/*Do
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
If the commit is after (higher up in the log than) origin/master, then it has not been pushed.*/


	}
}
