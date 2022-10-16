using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.gc_
{
	public class All
	{
		/// <summary>
		/// 
		/// </summary>
		public static void Exe()
		{
			/*
			  had the same issue, still after following all the advice in this thread:

git reflog expire --expire-unreachable=now --all
git gc --prune=now
git fsck --unreachable --no-reflogs   # no output
git branch -a --contains <commit>     # no output
git show <commit>                     # still shows up
If it's not a reflog and not a branch, ...it must be a tag!

git tag                             # showed several old tags created before the cleanup
I removed the tags with git tag -d <tagname> and redid the cleanup, and the old commits were gone.

accidentally hit the same situation and found my stashes contain reference to the unreachable commit, and thus the presumed unreachable commit was reachable from stashes.

			*/
			/*

These were what I did to make it truly unreachable.

git stash clear
git reflog expire --expire-unreachable=now --all
git fsck --unreachable
git gc --prune=now

			 */

			

		}
		/*git gc --aggressive --prune=all     # remove the old files*/
		public static void byAggressivePruneAll()
			{

			}
	}
}
