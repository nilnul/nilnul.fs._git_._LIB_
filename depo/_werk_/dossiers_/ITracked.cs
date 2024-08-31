namespace nilnul.fs.git.depo._werk_.dossiers_
{
	/// exist and tracked.
	/// <summary>
	/// if a file is in head, but not in index, then it's not tracked.
	/// demo:
	///		for a repo with a head snap, and now the status is clear.
	///		remove from index a file, but not from the werk
	///		,now the file will be shown as unstagedRemoval, and also untracked file.
	/// </summary>
	/// 
	interface ITracked:IDossiers
	{
		

	}

}
