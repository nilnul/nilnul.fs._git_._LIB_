namespace nilnul.fs.git.depo.repo
{
	/// tracker; a moving tip|head.
	/// <summary>
	/// docs in ".git/refs/heads", each of which stores a hash of a commit.
	/// By this definition, <see cref="repo.head.branch"/> is excluded. That is an imaginary|unborn branch, and hasnot been stored in place, there is no commit be pointed to.
	/// git branch will not list an unborn branch;
	/// for unborn branch, <see cref="module.head"/> or <see cref="module.repo.head"/>
	/// </summary>
	/// <remarks>
	/// Even branch might indict it's from a tree structure, the repo snapshots are in fact from a collecion of disjoint <see cref="nilnul.rel_.net_.IDac"/>s, each of which is not necessarily a tree.
	/// </remarks>
	/// alias:
	///	vs:
	///		<see cref="ISnaps"/>
	///		graphlet
	///		ideal
	///		filter
	///		ancestry
	interface IBranch :git.repo.IBranch,IBranchish
	{


	}


}
