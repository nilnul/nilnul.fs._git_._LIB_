using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.branch.push.log
{
	public class Lag
	{
		/*f you want to see all commits on all branches that aren't pushed yet, you might be looking for something like this:

git log --branches --not --remotes
And if you only want to see the most recent commit on each branch, and the branch names, this:

git log --branches --not --remotes --simplify-by-decoration --decorate --oneline
shareedit
edited Jul 24 '12 at 1:14

alex
338k166765911
answered Jul 26 '10 at 20:36

cxreg
8,08511410
5
This is awesome. In a related scenario I had two local branches with two upstream branches, and one local hand been merged into the other. I wanted to know which commits were safe to rebase, but the normal git log master..HEAD wouldn't work since there were multiple upstreams. This post led me to git log MyBranch --not --remotes to show all the commits that have not been pushed to any upstream in a single branch. – pavon Jul 12 '14 at 2:10
This was so useful I aliased it in my zsh config. Thanks. – Scotty C. Jul 29 '15 at 21:34
I understand that your second command is also listing the commits that aren't pushed yet, only it shows just one per branch. – Stephane Mar 30 '16 at 6:19
--decorate shows the branches as well. --graph makes it even more obvious. – Ray Dec 20 '16 at 11:19
Note that these commands list only commits that haven't been pushed in any branch. Example: say you have branch develop with branch feat-NewThing. You make changes locally to feat-NewThing. (Log has changes.) You then push feat-newThing to it's remote branch. (Log is empty). You merge local feat-newThing to develop locally. Assuming a fast-forward, the log still has no changes. – Patrick W Jan 17 '17 at 0:02
This is the actual solution. The only one that works generally without the need to specify a branch or the need to have an upstream defined. – thisismydesign Sep 5 '17 at 10:02
This works also even if no upstream has been configured for a branch. – Marinos An Oct 16 '17 at 11:15
@pavon Couldn't this also be git log HEAD --not --remotes for the current branch? – Marinos An Oct 16 '17 at 11:19 */

		static public string Txt(
			nilnul.fs.git.ModuleI module
			, nilnul.fs.git.repo._branch.Name branch
			, nilnul.win.prog_.Git git=null
		) {
			return nilnul.win.prog_.git.run.result.msg._TrimmedX.Txt(module, $"log {branch} --not --remotes" , git);
		}
	}
}
