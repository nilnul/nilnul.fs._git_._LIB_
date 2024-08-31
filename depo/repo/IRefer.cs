namespace nilnul.fs.git.depo.repo
{
	/// <summary>
	/// can refer to a snap, tree, blob, tag, or the ref itself, or nothing if it's unborn.
	/// </summary>
	/// <remarks>
	/// like a dynamic variable;either from the $GIT_DIR/refs directory or from the $GIT_DIR/packed-refs file
	/// </remarks>
	/// alias:
	///		<see cref="git.repo._ReferX"/>
	///		revision
	public interface IRefer
		//:repo.snap.IRepresentation
	{ }
}
