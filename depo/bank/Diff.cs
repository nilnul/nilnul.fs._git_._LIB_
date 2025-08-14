using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.bank
{
	/// for diff, it's naturally to regard the latter as the target as modification goes in align with time;
	/// <summary>
	/// head as the src, werk as the tgt;
	/// You have to use
	/// git diff HEAD
	/// (you may want to add --name-only or similar) to see what, if anything, is different between the work-tree and the HEAD commit
	/// , or
	/// git diff HEAD~
	/// </summary>
	/// <remarks>
	/// if you've made changes, added them to the index, and then backed out these changes in the working tree, you’ll get no results for git diff HEAD (because there is no difference) but you will get output for git diff --cached because there are still changes in the index.
	/// </remarks>
	internal class Diff
	{
	}
}
