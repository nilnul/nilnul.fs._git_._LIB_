namespace nilnul.fs.git.depo._werk_.destinys_.tracked_
{
	/// <summary>
	/// on basis of index, observer werk.
	/// 
	/// git ls-files --modified
	/// , includes:
	///		- <see cref="nonexist_.ITracked"/>,  that is: those deleted from werk.
	///		- <see cref="dossiers_.tracked_.IRevised"/>, that is: those altered at werk with respect to stage. 
	/// </summary>
	/// <remarks>
	///	 all the revised, including: updated and deleted. in git, this is called modified.
	/// </remarks>
	/// considers a deleted file modified
	/// 
	/// alias:
	///		edact
	///		revised
	///		smear
	///		released
	///		declassified
	///		reduced
	///		reformed
	///		downsized
	///		regressed.
	///		curtail
	/// 
	interface IRedactedVsPier :ITracked {

	}

}
