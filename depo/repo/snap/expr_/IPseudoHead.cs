namespace nilnul.fs.git.depo.repo.snap.expr_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		tip
	///		pseudoRef
	///		
	///	<see cref="fs.git.depo._repo_.PseudoRefI"/>
	interface IPseudoHead {
		/*
		 
FETCH_HEAD
records the branch which you fetched from a remote repository with your last git fetch invocation.

ORIG_HEAD
is created by commands that move your HEAD in a drastic way (git am, git merge, git rebase, git reset), to record the position of the HEAD before their operation, so that you can easily change the tip of the branch back to the state before you ran them.

MERGE_HEAD
records the commit(s) which you are merging into your branch when you run git merge.

REBASE_HEAD
during a rebase, records the commit at which the operation is currently stopped, either because of conflicts or an edit command in an interactive rebase.

REVERT_HEAD
records the commit which you are reverting when you run git revert.

CHERRY_PICK_HEAD
records the commit which you are cherry-picking when you run git cherry-pick.

BISECT_HEAD
records the current commit to be tested when you run git bisect --no-checkout.

AUTO_MERGE
records a tree object corresponding to the state the ort merge strategy wrote to the working tree when a merge operation resulted in conflicts.		 
		 */
	}
}
