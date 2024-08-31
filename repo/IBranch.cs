namespace nilnul.fs.git.repo
{
	/// <summary>
	/// note this is a branch of repo, not <see cref="git.IDepo"/>; so the branch cannot be without <see cref="repo.Snap"/>.
	/// git branch will list branches excluding the current head if it's an unborn (ie., no commits) branch.
	/// </summary>
	/// <remarks>
	/// empty branch shall be regarded as header, not as branch; so this is more like a tip leading an evolvement.
	/// </remarks>
	/// alias:
	///		bookmark
	///		
	public interface IBranch
	{
	}

}
