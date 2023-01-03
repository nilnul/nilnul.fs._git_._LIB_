using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.current_.branch.assign_.snap_
{
	/// <summary>
	/// </summary>
	internal class _AlignedX
	{
		///git reset --mixed (branch where you want to go)
		/*
		 this time the index is also modified to match. If we run git commit at this point, nothing will happen since the index matches HEAD.
		We still have the changes in the working directory, but since they're not in the index, git status shows them as unstaged. To commit them, you would git add and then commit as usual.
		 */
	}
}
