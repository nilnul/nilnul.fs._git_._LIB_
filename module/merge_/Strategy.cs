using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.merge_
{
	class Strategy
	{
	}
	/*
	 Choosing a merge strategy beforehand

You may have noticed that resolving merge conflicts with ours and theirs in the middle of a rebase or merge is the same, except that the semantics of what ours and theirs refer to are different. Both use a flag on git checkout to choose what must be done per file. This is very useful if you were not planning on having merge conflicts and they pop up in the middle of a rebase/merge or if you want to use a different strategy depending on the file. This means for one file you could use ours, another theirs, and another could be done manually.

In instances that you know that you always want to resolve merge conflicts in the same way, you can choose a merge strategy (such as ours or theirs) before performing the rebase or merge. The default merge strategy is a recursive merge. You can also specify the algorithm to use for a recursive merge (patience, minimal, histogram, or myers), but we will not cover those in this post.

You can choose the merge strategy with the --strategy <strategy-name> option, or -s <strategy-name> for short.

For example:

##########
# REBASING
##########

# a rebase that wants to resolve all conflicts
# by taking the current branch's changes
git rebase -s theirs rebase_branch
# a rebase that wants to resolve all conflicts
# with the rebase_branch changes
git rebase -s ours rebase_branch

#########
# MERGING
#########

# a merge that wants to resolve all conflicts
# by taking the current branch's changes
git merge -s ours merge_branch
# a merge that wants to resolve all conflicts
# with the merge_branch changes
git merge -s theirs merge_branch


Now you should be able to add the ours and theirs options to your nilnul.win.prog_.Git merge resolution arsenal. Whenever you find yourself taking all of the changes from a single branch, that should be your queue to use ours or theirs. And don't forget that the meaning of ours and theirs changes within a rebase.

	 */
}
