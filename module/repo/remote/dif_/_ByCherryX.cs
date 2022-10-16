using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote.dif_
{
	/*
	Git: See all unpushed commits or commits that are not in another branch
If you need to find out which of your local commits are not on the remote server do this:

COPY
git cherry -v
The -v option prints out the commit messages. Without it you will see only the SHA1 codes.

You may also compare against another (upstream) branch like that:

COPY
git cherry -v origin/somebranch
This tool is especially useful when you have a ton of commits after a merge and want to know the commit differences between branches.
*/
	static public class _ByCherryX
	{
	}
}
