using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._submodule
{
	/// <summary>
	/// Git records the commit id for added submodule content the same way it records the blob id for added file content, as an id, listed in the index or a recorded tree. 
	/// Basically, it's a record for the superproject to remember the commit of submodule.
	/// the superproject tracks the submodule via a gitlink entry in the tree at path/to/bar;
	/// </summary>
	internal class GitLink
	{
	}
}
