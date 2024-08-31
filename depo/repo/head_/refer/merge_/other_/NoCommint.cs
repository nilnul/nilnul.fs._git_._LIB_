using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.head_.branchish.merge_.other_
{
	/// <summary>
	/// git merge {otherBranch}  --no-commit --no-ff
	///  
	/// </summary>
	/// <remarks>
	///perform the merge and stop just before creating a merge commit, to give the user a chance to inspect and further tweak the merge result before committing.
	///Note that fast-forward updates do not create a merge commit and therefore there is no way to stop those merges with --no-commit. Thus, if you want to ensure your branch is not changed or updated by the merge command, use --no-ff with --no-commit.
	/// </remarks>
	/// 
	internal class NoCommint
	{
	}
}
