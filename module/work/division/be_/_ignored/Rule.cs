using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._ignore_
{
	/*Yes. /dir will match a file named dir; /dir/ would not.

Both would match a directory named dir.

/dir/ and /dir/* are equivalent.
Be aware that /dir/ and /dir/* are NOT equivalent! The first will ignore the whole directory without even look in its contents. The second may ignore the whole directory, but only if nilnul.win.prog_.Git doesn't find anything interesting in there to track. Suppose that you have !.gitkeep in your rules (like everybody) and a .gitkeep file in that directory. It'll have the desired effect only with the second form. – Victor Schröder Jul 25 '16 at 3:48
 */
	/*So !* as the first line in your .gitignore will clear all previous patterns.*/

	class Rule
	{
	}
}
