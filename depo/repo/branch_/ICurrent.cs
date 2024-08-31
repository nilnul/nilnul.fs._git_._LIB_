using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.branch_
{
	/// <summary>
	/// the branch is the one in <see cref="repo.head_"/>;
	/// </summary>
	/// vs:
	///		<see cref="repo.head_.branchish"/> means the .git/HEAD,  which contains the branch as a <see cref="git.module.repo.refer_"/>, whileas this means the file in .git/refs/heads/someBranch, the content of which is a snap id;
	internal class ICurrent
	{
	}
}
