namespace nilnul.fs.git.repo
{
	/// <summary>
	/// for a bare repo, we have 0 worktrees;
	/// for a normal depo, we have 1 worktree: ../ relative to the repo, which is embedded. This worktree is called "main" worktree.
	/// we can have extra "linked" worktrees. eg:
	///		git worktree add ../hotfix
	///			#creates new branch hotfix and checks it out at path ../hotfix. 
	///		
	/// 
	/// </summary>
	interface IWorktrees {

	}
}
