using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.branch_
{
	/// <summary>
	/// stored in : .git/refs/remotes/someSvr/branchName.
	///	,stored as: refs/remotes/someSvr/branchName
	/// , displayed as: someSvr/branchName
	/// </summary>
	/// <remarks>
	/// note: remote means local pointer pointing to a svr. not a branch on the svr.
	/// </remarks>
	/// eg:
	///		if you have a remote named bob you might also have refs/remotes/bob/hacks/feep that tracks Bob's hacks/feep.
	/// vs:
	///		<see cref="ILocal"/>
	internal class IRemote
	{
	}

}
