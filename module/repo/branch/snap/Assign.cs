using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.snap
{

	/// https://stackoverflow.com/questions/5471174/move-branch-pointer-to-different-commit-without-checkout
	/// Chris Johnsen answered Mar 29, 2011 at 10:38
	/// Nathan edited Feb 6 at 16:14
	/// 
	/// <summary>
	/// git branch --force <branch-name> [<new-tip-commit>]
	/// If new-tip-commit is omitted, it defaults to the current commit.
	///		eg:
	///			git branch --force master
	/// new-tip-commit can be a branch name(e.g., master, origin/master).
	/// </summary>
	class Assign
	{
	}
}
