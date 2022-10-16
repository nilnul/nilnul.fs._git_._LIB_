using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.reference
{
	class _DelX
	{
		static public void UpdateRef() {
			/*git update-ref -d refs/original/refs/heads/master*/
		}
		static public void PushNull()
		{ /*
			This is a ref. Normally created by git filter-branch - it is a pointer to where your branch was before you run git filter-branch.
And to delete any ref, you can always push nothing to it in the local repository:
git push . :refs/original/refs/heads/master
The other answers also covered pretty well other ways of deleting.
			 */
		}
	}
}
