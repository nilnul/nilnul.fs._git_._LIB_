namespace nilnul.fs.git.depo._werk_.dossiers_
{
	/// exist and tracked.
	///
	///
	/// 
	/// <summary>
	/// those in stage. note files in current revision are inherently staged, 
	/// to exclude a file ignored, even if it's tracked:
	///		git rm --cached <file>
	/// 
	/// if a file is in head, but not in index, then it's not tracked.
	/// </summary>
	/// <remarks>
	/// demo:
	///		for a repo with a head snap, and now the status is clear.
	///		remove from index a file, but not from the werk
	///		,now the file will be shown as unstagedRemoval, and also untracked file.
	///
	/// </remarks>
	/// 
	interface ITracked :IDossiers
	{
		

	}

}
