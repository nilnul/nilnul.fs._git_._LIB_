using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.gitTop.module.cfg.remote.branches
{
	public class Vw
	{
		/*git ls-remote --heads <remote-name> 
		 */



		/*
		 remote show shows all the branches on the remote, including those that are not tracked locally and even those that have not yet been fetched.
git remote show <remote-name>


It also tries to show the status of the branches relative to your local repo:
> git remote show origin
* remote origin
  Fetch URL: C:/git/.\remote_repo.git
  Push  URL: C:/git/.\remote_repo.git
  HEAD branch: master
  Remote branches:
    branch_that_is_not_even_fetched new (next fetch will store in remotes/origin)
    branch_that_is_not_tracked      tracked
    branch_that_is_tracked          tracked
    master                          tracked
  Local branches configured for 'git pull':
    branch_that_is_tracked merges with remote branch_that_is_tracked
    master                 merges with remote master
  Local refs configured for 'git push':
    branch_that_is_tracked pushes to branch_that_is_tracked (fast-forwardable)
    master                 pushes to master                 (up to date)


		 
		 */

	}
}
