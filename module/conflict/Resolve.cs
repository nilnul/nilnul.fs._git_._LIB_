using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.conflict
{
	public class Resolve
	{
		/*
git checkout --[ours/theirs] . will do what you want, as long as you're at the root of all conflicts. ours/theirs only affects unmerged files so you shouldn't have to grep/find/etc conflicts specifically.
 
For me this doesn't seem to recurse into subdirectories. – Daniel Baughman May 26 '16 at 15:01  
		 */

		/*
		 To checkout your own version you can use one of: 
git checkout HEAD -- <filename>

		or
		git checkout --ours -- <filename>
		 */
	}
}
