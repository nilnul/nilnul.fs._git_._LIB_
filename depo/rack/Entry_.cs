using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.rack
{
	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		<see cref="depo.repo.refers"/>, such as branch, tag (empty tag), head (undetached head is a refer to refer. or a refer.expr <see cref="depo.repo.refer.IExpr"/>)
	internal enum Entry_
	{
		Blob
			,
		Tree
			,
		Commit
			,
		/// <summary>
		/// annotation tag
		/// </summary>
		/// including empty tag?
		Tag

	}
}
