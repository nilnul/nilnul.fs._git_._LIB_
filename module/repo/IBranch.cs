namespace nilnul.fs.git.module.repo
{
	/// <summary>
	/// docs in ".git/refs/heads", each of which stores a hash of a commit.
	/// By this definition, <see cref="repo.head.branch"/> is excluded. That is an imaginary branch, and hasnot been stored in place, there is no commit be pointed to.
	/// </summary>
	/// <remarks>
	/// Even branch might indict it's from a tree structure, it is in fact from a collecion of disjoint <see cref="nilnul.rel_.net_.IDac"/>s, each of which is not necessarily a tree.
	/// </remarks>
	/// alias:
	///	vs:
	///		<see cref="ISnaps"/>
	class IBranch
	{


	}
}
