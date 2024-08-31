namespace nilnul.fs.git.depo
{
	/// <summary>
	/// stage and work;
	/// These two are not archived|saved in the repo, so here we find a way to store it in a particular sequence of snapshots in the repo. we achieve this by doing something similar to "git stash": first commit the index, then commit the werk;
	/// </summary>
	/// <remarks>
	/// in mercury, there is no index but a list what in the worktree needs to commited; in git, the index acts more or less as that list;
	/// if you choose to commit directly, you can work the mercurary way: leave the index unattended under the hood; 
	/// </remarks>
	/// alias:
	///		stow
	///			"st"age, "w"'o'rk, hwere wo is reversed to ow;
	///			,
	///			stow away;
	///		shelf
	///			,but <see cref="IShelf"/> means repo9stage
	///		stash
	///		stage9work
	///	vs:
	///		<see cref="IShelf"/> which excludes werk, whileas this includes work, and stage.
	///		<see cref="fs.git.depo.IBank"/>
	public interface IStow { }
}
