using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.stash.push_
{
	/*When you use --keep-index, the script does not change the saved stash in any way. Instead, after the git reset --hard operation, the script uses an extra git read-tree --reset -u to wipe out the work-directory changes, replacing them with the "index" part of the stash.
In other words, it's almost like doing:
git reset --hard stash^2
except that git reset would also move the branch—not at all what you want, hence the read-tree method instead.*/
	interface IndexI
	{
	}
}
