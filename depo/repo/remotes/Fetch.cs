using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remotes
{
	static  class _FetchX
	{
		/*
		 "git fetch" learned --all and --multipleoptions, to run fetch from many repositories, and --prune option to remove remote tracking branches that went stale. 
		 
		These make "git remote update" and "git remote prune" less necessary (there is no plan to remove "remote update" nor "remote prune", though).
		 
		 */

		/*
I suggest you run this:

$ git fetch --all
Fetching origin
Fetching upstream
This will fetch the latest data from all remotes.

Then you run:

$ git branch -v
master       ef762af [ahead 3] added attach methods
* testing      4634e21 added -p flag
upstream     1234567 [ahead 1, behind 7] updated README.md
This will show which branches you're ahead or behind on.

I posted this because none of the other answers mention fetching the remote data, that step is crucial.*/
		public static void All()
		{

		}
	}
}
