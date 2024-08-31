namespace nilnul.fs.git.depo.repo
{
	///In the past, .git/HEAD was a symbolic link pointing at refs/heads/master.
	///But symbolic links are not entirely portable, so they are now deprecated and symbolic refs (as described above) are used by default.
	/// <summary>
	/// the "head" file in ".git/"
	/// , which might be a branch that exists or does not, or might be a snap.
	/// </summary>
	/// <remarks>
	/// svr would also honor this by setting it as the default branch;
	/// </remarks>
	/// <see cref="_cfg_.IHead"/>
	/// alias:
	///		head
	///		current
	///			, per nilnul naming rule, <see cref="nilnul.fs.git.depo.IHeld"/>, whose namespace is shorter than this, hence it will in herit this, not the other way around; and the name of this shall be diffrent than that.
	/// vs:
	///		<see cref="nilnul.fs.git.depo.IHeld"/> which is in fact this;

	public interface IHead
		:
		nilnul.fs.git.repo.IHead
		,fs.git.depo.repo.IRefer
	{

	}
}
