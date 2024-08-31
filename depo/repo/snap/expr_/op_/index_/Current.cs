using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.expr_.op_.index_
{
	/// <summary>
	/// use the @ construct with an empty ref part to get at a reflog entry of the current branch.
	/// eg:
	///		@{1}
	///		@{-1}
	///			,the <n>th branch/commit checked out before the current one
	/// </summary>
	internal class Current
	{
	}
}
