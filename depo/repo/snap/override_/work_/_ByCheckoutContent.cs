using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snap.override_.work_
{
	/// <summary>
	///stackoverflow.com/questions/51814990/git-how-do-you-replace-your-current-working-directory-with-a-previous-commit-wi
	///answered Aug 13, 2018 at 7:17
	///by Alderath
	///
	/// eg:
	///		git checkout master
	/// git checkout 49a732c -- .
	///
	/// Then you specify a file (in this case . (the root directory of your repo)) as an argument to git checkout, the checkout will not switch branch (the repo HEAD will remain the same). It will just update the index to make that file match the version of that file from the specified commit. Since you specified the root directory of the repo, all files in the index will be updated to match the specified commit 49a732c
	///
	/// However, this just checks out all files from 49a732c into the working tree; if the working tree has new files not in 49a732c, these will still be in the working tree after committing, so the result will not be identical to 49a732c
	/// 
	/// </summary>
	class _ByCheckoutContent
	{
	}
}
