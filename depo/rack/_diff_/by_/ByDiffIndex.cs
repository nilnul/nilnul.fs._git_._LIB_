using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.rack._diff_.by_
{
	/// <summary>
	/// git-diff-index --cached <tree-ish>
	///		,compares the <tree-ish> and the index.
	/// </summary>
	/// <remarks>
	///git diff-index --cached should always be entirely equivalent to actually doing a git write-tree and comparing that.
	///So doing a git diff-index --cached is basically very useful when you are asking yourself "what have I already marked for being committed, and what’s the difference to a previous tree".
	/// </remarks>
	/// for repo.snap.tree.diff, <see cref="repo.snap.tree."/>
	internal class ByDiffIndex
	{
	}
}
