using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._stash
{
	/// <summary>
	/// For scripting, use git stash create (which produces the hash ID of the created stash on standard output, or nothing on standard output if no stash was created). You can then use git stash store to insert the created stash as stash@{0}, if and only if one was actually created.
	/// $ git stash create
	/// /// if it returns nonempty
	/// $git stash store
	/// $git stash pop stash@{0}
	/// </summary>
	class ICreate
	{
	}
}
