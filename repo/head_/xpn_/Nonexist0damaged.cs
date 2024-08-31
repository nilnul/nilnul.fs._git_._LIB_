using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo.head_.xpn_
{
	/// <summary>
	/// if HEAD is nonexistent or damaged:
	/// </summary>
	internal class Nonexist0damaged
	{
		/// > git rev-parse HEAD --
		/// fatal: Not a git repository(or any of the parent directories): .git
		///
		/// to fix this:
		/// 
		/// Although, in theory, you could attempt to do
		/// git symbolic-ref HEAD refs/heads/master
		/// newer git versions don't recognize a .git as a git repository unless it already contains a HEAD so this won't work to create a new one.
		/// 
		/// so just do:
		///		echo ref: refs/heads/master >.git/HEAD


	}
}
