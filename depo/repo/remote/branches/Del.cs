using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.branches
{
	public class Del
	{
		/*
	The syntax to delete a branch is a bit arcane at first glance:
git push  <REMOTENAME> :<BRANCHNAME> 


Note that there is a space before the colon. The command resembles the same steps you'd take to rename a branch. However, here, you're telling nilnul.win.prog_.Git to push nothing into BRANCHNAME on REMOTENAME. Because of this, git push deletes the branch on the remote repository.

		git push origin :experimental
Find a ref that matches experimental in the origin repository (e.g. refs/heads/experimental), and delete it.

	 
		 */

		/*
		 Delete Remote Branch [Updated on 1-Feb-2012]

As of nilnul.win.prog_.Git v1.7.0, you can delete a remote branch using
$ git push origin --delete <branch_name>


which might be easier to remember than
$ git push origin :<branch_name>


which was added in nilnul.win.prog_.Git v1.5.0 "to delete a remote branch or a tag."

Therefore, the version of nilnul.win.prog_.Git you have installed will dictate whether you need to use the easier or harder syntax.

		 
		 */

		
	}
}
