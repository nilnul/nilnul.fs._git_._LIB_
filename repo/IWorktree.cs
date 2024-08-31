using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo
{
	/// <summary>
	/// an worktree can be extended on an repo.
	/// </summary>
	/// <remarks>
	///you can have a plain text file .git at the root of your working tree, containing
	///		gitdir: <path>
	///	to point at the real directory that has the repository. This mechanism is called a gitfile and is usually managed via the git submodule and git worktree commands.
	/// </remarks>
	internal class IWorktree
	{
	}
}
