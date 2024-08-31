using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.remote._push._cfg
{
	internal enum Mode4branch
	{
		/// <summary>
		///  do not push anything
		/// </summary>
		nothing,

		/// <summary>
		/// (default before Git 2.0) push all matching branches;
		/// All branches having the same name in both ends are considered to be matching.

		/// </summary>
		matching,
		/// <summary>
		///  push the current branch to its upstream branch (tracking is a deprecated synonym for upstream)
		/// </summary>


		upstream
			,
		/// <summary>
		///  push the current branch to a branch of the same name
		/// </summary>

		current
,
		/// <summary>
		///  (new in Git 1.7.11, default since Git 2.0) like upstream, but refuses to push if the upstream branch's name is different from the local one
		/// </summary>
		/// <remarks>
		///  This is the safest option and is well-suited for beginners.
		/// </remarks>
		simple

	}
}
