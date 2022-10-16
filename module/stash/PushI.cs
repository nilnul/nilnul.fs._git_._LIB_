using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash
{
	/*git stash save (the default action for git stash) makes a commit that has at least two parents (see this answer to a more basic question about stashes). The stash commit is the work-tree state, and the second parent commit stash^2 is the index-state at the time of the stash.
	 After the stash is made (and assuming no -p option), the script—git stash is a shell script—uses git reset --hard to clean out the changes.


		
		 */
	/// <summary>
	/// 
	/// </summary>
	interface PushI
	{
	}
}
