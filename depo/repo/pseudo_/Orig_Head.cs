using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.repo.pseudo_
{
	/// <summary>
	/// </summary>
	public interface IOrigHead
	{

		/*
		 * ORIG_HEAD is previous state of HEAD, set by commands that have possibly dangerous behavior, to be easy to revert them. It is less useful now that nilnul.win.prog_.Git has reflog: HEAD@{1} is roughly equivalent to ORIG_HEAD (HEAD@{1} is always last value of HEAD, ORIG_HEAD is last value of HEAD before dangerous operation).
		 * 
	/// Before the operation: git reset, ORIG_HEAD is set to the tip of the current branch, as after the operation the branch might point to another commit;
		 * 
		 */

		
	}
}
