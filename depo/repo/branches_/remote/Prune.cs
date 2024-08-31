using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branches_.remote
{
	class Prune
	{
		/*
		 * Don't forget to do a git fetch --all --prune on other machines after deleting the remote branch on the server. 
		 After deleting the local branch with git branch -d and deleting the remote branch with git push origin --delete other machines may still have "obsolete tracking branches" (to see them do git branch -a). To get rid of these do git fetch --all --prune. 
		 */

		/*
		 git fetch origin --prune
git fetch origin -p # Shorter
*/


	}
}
