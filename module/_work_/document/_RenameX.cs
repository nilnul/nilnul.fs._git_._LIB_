using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._work_.document
{
	/// <summary>
	/// 
	/// </summary>
	class _RenameX
	{
		/*Remember: git does not track file renames. It tracks file contents.
When the index contains a deletion and a creation for different files with the same contents, git's rename detection will (probably) conclude that's a rename, and helpfully display it as such. This doesn't actually change what's in the index, though. What "really" happened was indeed a deletion-then-creation, git is just trying to display it more helpfully.*/
	}
}
