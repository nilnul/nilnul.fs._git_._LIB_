using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.head_.branchish_
{
	/// <summary>
	/// in the HEAD, the branch is not born yet; so it's not <see cref="depo.repo.IBranch"/>
	/// </summary>
	/// <remarks>
	/// a reference name, an unborn branch, or a branch with no commits;
	/// </remarks>

	public interface IUnborn:IBranchish
	{
	}
}
