namespace nilnul.fs.git.depo.repo.snap.expr_
{
	/// <summary>
	/// eg:
	///		HEAD@{0} will resolve to the current HEAD
	///		HEAD@{1} will resolve to the previous head. This can only be used by references since it makes use of the reference log.($GIT_DIR/logs/<refname>)
	///		
	/// </summary>
	internal class IIndexPerLog
	{
	}


}
