namespace nilnul.fs.git.depo.repo.head_
{
	/// <summary>
	/// <see cref="held_.IBranch"/> or <see cref="IDetached"/>.
	/// excluding:unborn branch;
	/// 
	/// </summary>
	/// <remarks>
	/// a born head.
	/// current is a snap, be it directly pointed to in detach mode, or indirectly by a branch;
	/// </remarks>
	/// alias:
	///		born
	///		hatched
	///			,like laying an egg;
	///			,same initial as head
	///			, like "detach", "attach_.snapped"
	///		hatchen
	///		snappable
	///		snappy
	interface IHatched:depo.repo.IHead{ }

	

}
