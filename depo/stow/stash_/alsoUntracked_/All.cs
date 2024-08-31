using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.depo.stow.stach_.untracked_
{
	/// <summary>
	/// git stash --all
	/// which stashes all files, including untracked and ignored files.
	/// </summary>
	/// <remarks>
	///The point is to have a clean working tree after stashing. 
	///Warning: there seems to be (or have been) situations in which contents of ignored directories could be deleted permanently;
	/// </remarks>
	internal class All
	{
	}
}
