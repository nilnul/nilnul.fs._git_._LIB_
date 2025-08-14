using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.snap.be_
{
	///Commits will be reachable via reflog for the gc.reflogExpire timespan, with a default of 90 days.
	/// Commits that are (still) referenced by the reflog are considered reachable and not dangling. Thus running git log –g is contrary to what you wanted, so no surprises here.
	/// git fsck is the right way for accessing dangling commits.
	///<summary>
	/// 
	/// </summary>
	internal class IDangling
	{
	}
}
