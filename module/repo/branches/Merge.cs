using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo
{
	class Merge
	{
		/*
		 Merge the changes from upstream/master into your local master branch. This brings your fork's master branch into sync with the upstream repository, without losing your local changes.
$ git merge upstream/master
Updating a422352..5fdff0f
Fast-forward
 README                    |    9 -------
 README.md                 |    7 ++++++
 2 files changed, 7 insertions(+), 9 deletions(-)
 delete mode 100644 README
 create mode 100644 README.md

		If your local branch didn't have any unique commits, nilnul.win.prog_.Git will instead perform a "fast-forward":
$ git merge upstream/master
Updating 34e91da..16c56ad
Fast-forward
 README.md                 |    5 +++--
 1 file changed, 3 insertions(+), 2 deletions(-)




		 */


		/*
		 You can use --allow-unrelated-histories to force the merge to happen
		 */

		/*
		 
git merge branchname takes new commits from the branch branchname, and adds them to the current branch. If necessary, it automatically adds a "Merge" commit on top.


•git rebase branchname takes new commits from the branch branchname, and inserts them "under" your changes. More precisely, it modifies the history of the current branch such that it is based on the tip of branchname, with any changes you made on top of that.


•git pull is basically the same as git fetch; git merge origin/master.


•git pull --rebase is basically the same as git fetch; git rebase origin/master.


		 */
	}
}
