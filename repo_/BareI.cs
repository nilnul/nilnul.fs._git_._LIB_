using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.repo_
{
	/// <summary>
	/// bared repo, which is 
	/// </summary>
	public interface IBare
	{

		/*
		 As mentioned in "all about "bare" repos -- what, why, and how to fix a non-bare push" (at the bottom)
To make it a "real" bare repo, just delete all the files except .git, then mv .git/* .; rmdir .git.
Finally, edit the file called config and change bare = false to bare = true.
So if your destination repo has a config file with bare  = true, it is a bare repo.
		 */
	}
}
