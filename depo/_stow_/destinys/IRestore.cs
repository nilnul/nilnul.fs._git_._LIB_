using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo._stow_.destinys
{
	/// generally files are restored from the index for --worktree, and from HEAD for --staged.
	/// but,
	/// <summary>
	/// git restore --staged --worktree
	///
	///  defaults to take the contents out of "HEAD"
	/// </summary>
	internal class IRestore
	{
	}
}
