using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.snaps
{
	class Filter
	{
		/*
Find the last commit that affected the given path. As the file isn't in the HEAD commit, this commit must have deleted it.
git rev-list -n 1 HEAD -- <file_path>

		from git help rev-list:

		syntax for revlist 
		--options  <commit>…​ [ -- <paths>…​ ]

		-<number>
-n <number>
--max-count=<number>
Limit the number of commits to output.




		 */
	}
}
