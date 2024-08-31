namespace nilnul.fs.git.depo.repo.snap.expr_
{
	/// <summary>
	/// syntax:
	/// [<branchname>]@{upstream}
	/// , e.g. master@{upstream}, @{u}
	/// </summary>
	/// <remarks>
	///A branch B may be set up to build on top of a branch X (configured with branch.<name>.merge) at a remote R (configured with the branch X taken from remote R, typically found at refs/remotes/R/X.
	/// </remarks>
	interface IUpstream { }



}
