using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._rack_._objects.pack
{
	/// <summary>
	/// git-scm.com/docs/git-index-pack
	/// Reads a packed archive (.pack) from the specified file, builds a pack index file (.idx) for it, and optionally writes a reverse-index (.rev) for the specified pack. The packed archive, together with the pack index, can then be placed in the objects/pack/ directory of a Git repository.
	/// </summary>
	/// <remarks>
	///git-scm.com/docs/git-show-index
	///Read the .idx file for a Git packfile (created with git-pack-objects[1] or git-index-pack[1]) from the standard input, and dump its contents. 
	/// </remarks>
	internal class Index
	{
	}
}
